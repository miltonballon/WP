using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;

namespace ControllerLibrary
{
    public class RequestSheetGenerator
    {
        private TrimesterController trimesterController;
        private InvoiceController invoiceController;
        private ReportSheetController reportSheetController;
        private ConfigurationController configurationController;

        public RequestSheetGenerator()
        {
            trimesterController = new TrimesterController();
            invoiceController = new InvoiceController();
            reportSheetController = new ReportSheetController();
            configurationController = new ConfigurationController();
        }
        public ReportSheet GenerateRequestSheet()
        {
            Trimester ongoingTrimester = trimesterController.GetLastTrimester();
            ReportSheet reportSheet = new ReportSheet("Pedido", "PEDIDO DE MATERIALES Y SUMINISTROS\nm3\nc\nb");
            List<Invoice> invoices = getAllInvoicesOfLast2Trimester();
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            cells.AddRange(GenerateHeaderAndTableOfRequest(invoices, reportSheet.Tittle));
            reportSheet.Cells = cells;
            return reportSheet;
        }

        public List<Invoice> getAllInvoicesOfLast2Trimester()
        {
            List<Invoice> invoices = new List<Invoice>();
            List<Trimester> trimesters = trimesterController.GetLastTwoTrimester();
            foreach(Trimester trimester in trimesters)
            {
                invoices.AddRange(invoiceController.GetAllInvoicesByTrimester(trimester));
            }
            invoices = MatchProviders(invoices);
            return invoices;
        }

        public List<Invoice> MatchProviders(List<Invoice> invoicesIn)
        {
            List<Invoice> invoices = invoicesIn;
            int size = 0;
            while (size!=invoices.Count)
            {
                size = invoices.Count;
                invoices = Match(invoices[0],invoices);
            }
            invoices.Reverse();
            return invoices;
        }

        private List<Invoice> Match(Invoice invoice, List<Invoice> invoices)
        {
            List<Invoice> output = new List<Invoice>();
            for (int i = 1; i < invoices.Count; i++)
            {
                if (invoice.GetProvider().Equals(invoices[i].GetProvider()))
                {
                    foreach (InvoiceRow row in invoices[i].GetInvoiceRows())
                    {
                        invoice.AddInvoiceRow(row);
                    }
                    MergeRows(invoice);
                }
                else
                {
                    output.Add(invoices[i]);
                }
            }
            output.Add(invoice);
            return output;
        }

        private void MergeRows(Invoice invoice)
        {
            List<InvoiceRow> invoiceRows = invoice.GetInvoiceRows();
            int size = 0;
            while (size != invoiceRows.Count)
            {
                size = invoiceRows.Count;
                invoiceRows = Merge(invoiceRows[0], invoiceRows);
            }
            invoiceRows.Reverse();
            invoice.SetInvoiceRows(invoiceRows);
        }

        private List<InvoiceRow> Merge(InvoiceRow row, List<InvoiceRow> rows)
        {
            List<InvoiceRow> invoiceRows = new List<InvoiceRow>();
            int nElements = rows.Count;
            for (int i = 1; i < nElements; i++)
            {
                if (row.GetProduct().Equals(rows[i].GetProduct()))
                {
                    double quantity = row.GetQuantity();
                    row.SetQuantity(quantity + rows[i].GetQuantity());
                }
                else
                {
                    invoiceRows.Add(rows[i]);
                }
            }
            invoiceRows.Add(row);
            return invoiceRows;
        }

        private List<ReportSheetCell> GenerateHeaderAndTableOfRequest(List<Invoice> invoices, String title)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            int row = 0,
                column = 1;
            int numberCopies = invoices.Count;
            for (int i = 0; i < numberCopies; i++)
            {
                row = 1;
                ReportSheetCell cell = new ReportSheetCell(row, column, i + "");
                cell.WidthForCell(2);
                cells.Add(cell);
                column++;
                cell = new ReportSheetCell(row, column, "GOBIERNO AUTONOMO DEPARTAMENTAL");
                row++;
                cells.Add(cell);
                cell = new ReportSheetCell(row, column, "SECRETARIA DEPARTAMENTAL DE DESARROLLO HUMANO");
                row++;
                cells.Add(cell);
                cell = new ReportSheetCell(row, column, "SERVICIO DEPARTAMENTAL DE GESTION SOCIAL");
                row++;
                cells.Add(cell);
                cell = new ReportSheetCell(row, column, "COCHABAMBA- BOLIVIA");
                row += 2;
                cells.Add(cell);
                cell = new ReportSheetCell(row, column, title);
                cell.AddBold();
                cells.Add(cell);
                column += 5;
            }
            column = 2;
            for (int i = 0; i < numberCopies; i++)
            {
                String[] headers = { "ITEM\nw4\nc\nf", "DESCRIPCION\nw50\nc\nt\nf", "UNIDAD\nc\nf", "CANTIDAD\nc\nh25\nf" };
                cells.AddRange(GenerateSubHeaderOfRequest(row + 2, column+1));
                cells.AddRange(reportSheetController.FillRowWithText(row + 9, column, headers));
                cells.AddRange(reportSheetController.GenerateEnumerateTable(row + 9, column, 20, 3));
                List<InvoiceRow> invoiceRows = invoices[i].GetInvoiceRows();
                cells.AddRange(reportSheetController.FillTableWithInvoiceRows(row + 10, column + 1, invoiceRows, 3));
                ReportSheetCell emptyCell = new ReportSheetCell(row+30,column,"","h50");
                cells.Add(emptyCell);
                cells.AddRange(GenerateFooterOfRequest(row + 31, column - 1));
                column += 5;
            }
            return cells;
        }

        private List<ReportSheetCell> GenerateSubHeaderOfRequest(int row, int column)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            List<Trimester> trimesters = trimesterController.GetLastTwoTrimester();
            //configurationController.
            String stringFordetail = ToStringTrimester(trimesters);
            String stringForSchollarShips = ToStringTrimester(trimesters);
            String stringForDeparture = ToStringTrimester(trimesters);
            String[] unit = { "UNIDAD/CENTRO:\nb", "ASOCIACION CREAMOS" };
            String[] detail = { "DETALLE DE GASTOS CORRESPONDIENTE A:\nb", stringFordetail };
            String[] schollarships = { "N° DE BECAS\nb", "recuperar conf" };
            String[] departure = { "PARTIDA:\nb", "recuperar conf" };
            String[] date = { "FECHA:\nb", "en duda" };
            cells.AddRange(reportSheetController.FillRowWithText(row, column, unit));
            row++;
            cells.AddRange(reportSheetController.FillRowWithText(row, column, detail));
            row++;
            cells.AddRange(reportSheetController.FillRowWithText(row, column, schollarships));
            row++;
            cells.AddRange(reportSheetController.FillRowWithText(row, column, departure));
            row++;
            cells.AddRange(reportSheetController.FillRowWithText(row, column, date));
            row++;
            return cells;
        }

        private String ToStringTrimester(List<Trimester> trimesters)
        {
            String output = "";
            foreach (Trimester trimester in trimesters)
            {
                output += trimester.GetName() + " ";
            }
            return output;
        }

        private List<ReportSheetCell> GenerateFooterOfRequest(int row, int column)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            ReportSheetCell cell = new ReportSheetCell(row, column, "Myriam Roxana Ponce de León\nm4\nb\nc");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "PRESIDENTA ASOCIACION CREAMOS\nm4\nc");
            row++;
            cells.Add(cell);
            return cells;
        }
    }
}
