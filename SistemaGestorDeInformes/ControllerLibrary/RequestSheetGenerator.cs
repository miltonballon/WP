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

        public RequestSheetGenerator()
        {
            trimesterController = new TrimesterController();
            invoiceController = new InvoiceController();
            reportSheetController = new ReportSheetController();
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
                }
                else
                {
                    output.Add(invoices[i]);
                }
            }
            output.Add(invoice);
            return output;
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
                column += 4;
            }
            column = 2;
            for (int i = 0; i < numberCopies; i++)
            {
                String[] headers = { "ITEM\nw4\nc\nf", "DESCRIPCION\nw50\nc\nt\nf", "UNIDAD\nc\nf", "CANTIDAD\nc\nh25\nf" };
                cells.AddRange(reportSheetController.FillRowWithText(row + 3, column, headers));
                cells.AddRange(reportSheetController.GenerateEnumerateTable(row + 3, column, 20, 3));
                List<InvoiceRow> invoiceRows = invoices[i].GetInvoiceRows();
                cells.AddRange(reportSheetController.FillTableWithInvoiceRows(row + 5, column + 1, invoiceRows, 3));
                cells.AddRange(GenerateFooterOfRequest(row + 26, column - 1));
                column += 4;
            }
            return cells;
        }

        private List<ReportSheetCell> GenerateFooterOfRequest(int row, int column)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            ReportSheetCell cell = new ReportSheetCell(row, column, "Se considera causa de invalidación de la cotización, el no llenado de precios unitarios y totales");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "Los productos deben ser de primera calidad");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "Los precios ofertados tendrán vegencia de:");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "En caso de productos secos, colocar vencimiento:");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "Condiciones de pago:");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "Tiempo de Entrega:");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "Lugar de Entrega:");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "Dirección del Proveedor:");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "Teléfono de contacto:");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "Persona de Contacto:");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "Cheque a nombre de (Razon Social y/o titular de NIT)");
            row++;
            cells.Add(cell);
            return cells;
        }
    }
}
