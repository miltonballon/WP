    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;

namespace ControllerLibrary
{
    public class PurchaseSheetGenerator
    {
        private ReportSheetController reportSheetController;
        private InvoiceController invoiceController;
        private TrimesterController trimesterController;
       
        public PurchaseSheetGenerator()
        {
            trimesterController = new TrimesterController();
            invoiceController = new InvoiceController();
            reportSheetController = new ReportSheetController();
            //xlWorkSheet.Columns[3].ColumnWidth = 18;
        }
        public ReportSheet GenerateQuotationSheet()
        {
            Trimester ongoingTrimester = trimesterController.GetLastTrimester();
            ReportSheet reportSheet = new ReportSheet("OrdenCompra", "ORDEN DE COMPRA\nm6\nc");
            if (ongoingTrimester != null)
            {
                List<Invoice> invoices = invoiceController.GetAllInvoicesByTrimester(ongoingTrimester);
                List<ReportSheetCell> cells = new List<ReportSheetCell>();
                cells.AddRange(GenerateHeaderAndTableOfQuotation(invoices, reportSheet.Tittle));
                reportSheet.Cells = cells;
            }
            return reportSheet;
        }

        private List<ReportSheetCell> GenerateHeaderAndTableOfQuotation(List<Invoice> invoices, String title)
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
                column += 7;
            }
            column = 2;
            for (int i = 0; i < numberCopies; i++)
            {
                String[] headers = { "ITEM\nw4\nc\nv1", "DESCRIPCION\nw50\nb\nc\nv1\nt", "UNIDAD\nc\nv1", "CANTIDAD\nc\nv1","",""};
                String[] s1 = { "PRECIO EN BS.\nc\nm1" };
                    String[] s2= { "UNITARIO\nc", "TOTAL\nc" };
                String[] text = { "UNIDAD/CENTRO:", "ASOCIACION CREAMOS" };
                String[] text2 = { "FECHA:", " " };
                String[] text3 = { "PARTIDA:", " " };
                String[] text4 = { "SEÑOR:", " " };
                String[] text5 = { "AGRADEZCO ENTREGAR DE ACUERDO A SU COTIZACIÓN, LO QUE A CONTINUACIÓN SE DETALLA\nb", };
                cells.AddRange(reportSheetController.FillRowWithText(row + 2, column+1, text));
                cells.AddRange(reportSheetController.FillRowWithText(row + 3, column+1, text2));
                cells.AddRange(reportSheetController.FillRowWithText(row + 4, column + 1, text3));
                cells.AddRange(reportSheetController.FillRowWithText(row + 5, column + 1, text4));
                cells.AddRange(reportSheetController.FillRowWithText(row + 6, column + 1, text5));
                cells.AddRange(reportSheetController.FillRowWithText(row + 7, column, headers));
                cells.AddRange(reportSheetController.FillRowWithText(row + 8, column+4, s1));
                cells.AddRange(reportSheetController.FillRowWithText(row + 9, column+4, s2));
                cells.AddRange(reportSheetController.GenerateEnumerateTable(row + 10, column, 15,6));
                List<InvoiceRow> invoiceRows = invoices[i].GetInvoiceRows();
                cells.AddRange(reportSheetController.FillTableWithInvoiceRows(row + 11, column + 1, invoiceRows, 3));
                cells.AddRange(GenerateFooterOfTableOfReferentialPrices(row + 27, column, invoices[i]));
                cells.AddRange(GenerateFooterOfQuotation(row + 30, column +1));
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
        private List<ReportSheetCell> GenerateFooterOfQuotation(int row, int column)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            ReportSheetCell cell = new ReportSheetCell(row, column, "NOMBRE EJEMPLO");
            row++;
            cells.Add(cell);
            cell = new ReportSheetCell(row, column, "RESPONSABLE DE RECURSOS - ASOCIACION CREAMOS");
            row++;
            cells.Add(cell);
            
            return cells;
        }
    }
}
