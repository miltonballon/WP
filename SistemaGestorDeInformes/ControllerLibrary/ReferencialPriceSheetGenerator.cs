using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;

namespace ControllerLibrary
{
    public class ReferencialPriceSheetGenerator
    {
        private TrimesterController trimesterController;
        private InvoiceController invoiceController;
        private ReportSheetController reportSheetController;
        public ReferencialPriceSheetGenerator()
        {
            trimesterController = new TrimesterController();
            invoiceController = new InvoiceController();
            reportSheetController = new ReportSheetController();
        }

        public ReportSheet GenerateReferentialPricesSheet()
        {
            Trimester ongoingTrimester = trimesterController.GetLastTrimester();
            ReportSheet reportSheet = new ReportSheet("referenciales", "PRECIOS REFERENCIALES");
            if (ongoingTrimester != null)
            {
                List<Invoice> invoices = invoiceController.GetAllInvoicesByTrimester(ongoingTrimester);
                List<ReportSheetCell> cells = new List<ReportSheetCell>();
                cells.AddRange(GenerateHeaderAndTableOfReferentialPricesSheet(invoices, reportSheet.Tittle));
                reportSheet.Cells = cells;
            }
            return reportSheet;
        }

        public List<ReportSheetCell> GenerateHeaderAndTableOfReferentialPricesSheet(List<Invoice> invoices, String title)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            int row = 0,
                column = 1;
            int numberCopies = invoices.Count;
            for (int i = 0; i < numberCopies; i++)
            {
                row = 1;
                ReportSheetCell cell = new ReportSheetCell(row, column, i + "");
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
                column += 7;
            }
            column = 2;
            for (int i = 0; i < numberCopies; i++)
            {
                String[] headers = { "ITEM", "DESCRIPCION", "UNIDAD", "CANTIDAD", "PRECIO EN BS.", "UNITARIO", "TOTAL" };
                String[] text = { "UNIDAD/CENTRO:", "ASOCIACION CREAMOS" };
                cells.AddRange(reportSheetController.FillRowWithText(row + 2, column, text));
                String[] text1 = { "DOCUMENTO DE REFERENCIA:", "COTIZACIÓN" };
                cells.AddRange(reportSheetController.FillRowWithText(row + 3, column, text1));
                String[] text2 = { "FECHA:", " " };
                cells.AddRange(reportSheetController.FillRowWithText(row + 4, column, text2));
                cells.AddRange(reportSheetController.FillRowWithText(row + 5, column, headers));
                cells.AddRange(reportSheetController.GenerateEnumerateTable(row + 6, column, 15, 7));
                List<InvoiceRow> invoiceRows = invoices[i].GetInvoiceRows();
                cells.AddRange(reportSheetController.FillTableWithInvoiceRows(row + 6, column + 1, invoiceRows, 5));
                cells.AddRange(GenerateFooterOfTableOfReferentialPrices(row + 23, column - 1, invoices[i]));
                cells.AddRange(GenerateFooterOfReferentialPrices(row + 29, column - 1));
                column += 8;
            }
            return cells;
        }

        public List<ReportSheetCell> GenerateFooterOfTableOfReferentialPrices(int row, int column, Invoice invoice)
        {
            double total = invoice.GetTotal();
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            String[] text = { "TOTAL", total + "" };
            cells.AddRange(reportSheetController.FillRowWithText(row, column + 5, text));
            row++;
            String spellNumber = Util.NumberToString(total + "");
            String[] text1 = { "Son", spellNumber };
            cells.AddRange(reportSheetController.FillRowWithText(row, column, text1));
            row++;
            return cells;
        }

        public List<ReportSheetCell> GenerateFooterOfReferentialPrices(int row, int column)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            ReportSheetCell cell = new ReportSheetCell(row, column, "NOMBRE EJEMPLO");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "Responsable de Recursos Asociacion Creamos");
            row++;
            cells.Add(cell);
            return cells;
        }
    }
}
