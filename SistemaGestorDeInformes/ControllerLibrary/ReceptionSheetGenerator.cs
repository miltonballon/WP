using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;

namespace ControllerLibrary
{
    public class ReceptionSheetGenerator
    {
        private TrimesterController trimesterController;
        private InvoiceController invoiceController;
        private ReportSheetController reportSheetController;
        public ReceptionSheetGenerator()
        {
            trimesterController = new TrimesterController();
            invoiceController = new InvoiceController();
            reportSheetController = new ReportSheetController();
            //xlWorkSheet.Columns[3].ColumnWidth = 18;
        }
        public ReportSheet GenerateReceptionSheet()
        {
            Trimester ongoingTrimester = trimesterController.GetLastTrimester();
            ReportSheet reportSheet = new ReportSheet("Acta de Recepción", "ACTA DE CONFORMIDAD\nc\nm4\nh25\nf");
            if (ongoingTrimester != null)
            {
                List<Invoice> invoices = invoiceController.GetAllInvoicesByTrimester(ongoingTrimester);
                List<ReportSheetCell> cells = new List<ReportSheetCell>();
                cells.AddRange(GenerateHeaderAndTableOfReception(invoices, reportSheet.Tittle));
                reportSheet.Cells = cells;
            }
            return reportSheet;
        }

        private List<ReportSheetCell> GenerateHeaderAndTableOfReception(List<Invoice> invoices, String title)
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
                cell = new ReportSheetCell(row, column, "GOBIERNO AUTONOMO DEPARTAMENTAL\nc\nm4");
                row++;
                cells.Add(cell);
                cell = new ReportSheetCell(row, column, "SECRETARIA DEPARTAMENTAL DE DESARROLLO HUMANO\nc\nm4");
                row++;
                cells.Add(cell);
                cell = new ReportSheetCell(row, column, "SERVICIO DEPARTAMENTAL DE GESTION SOCIAL\nc\nm4");
                row++;
                cells.Add(cell);
                cell = new ReportSheetCell(row, column, "COCHABAMBA-BOLIVIA\nc\nm4");
                row ++;
                cells.Add(cell);
                cell = new ReportSheetCell(row, column, title);
                row++;
                cells.Add(cell);
                cell = new ReportSheetCell(row, column, "En la ciudad de Cochabamba, dentro del segundo trimestre...2017... En las instalciones la Asociación Creamos, se realizó la entrega de VIVERES SECO, según el siguiente detalle:\nc\nh52");
                row++;
                cells.Add(cell);
                cell = new ReportSheetCell(row, column, "\nh4");
                cell.AddBold();
                cells.Add(cell);
                column += 5;
            }
            column = 2;
            for (int i = 0; i < numberCopies; i++)
            {
                String[] headers = { "ITEM\nw4\nc\nv1", "DESCRIPCION\nw40\nb\nc\nt\nv1", "UNIDAD\nw8\nc\nv1", "CANTIDAD\nw10\nc", "OBSERVACION\nw15\nc\nv1" };
                String[] s1 = { "ENTREGADA\nc" };
                cells.AddRange(reportSheetController.FillRowWithText(row + 1, column, headers));
                cells.AddRange(reportSheetController.FillRowWithText(row + 2, column+3, s1));
                cells.AddRange(reportSheetController.GenerateEnumerateTable(row + 3, column, 12, 5));
                List<InvoiceRow> invoiceRows = invoices[i].GetInvoiceRows();
                cells.AddRange(reportSheetController.FillTableWithInvoiceRows(row + 5, column + 1, invoiceRows, 3));
                cells.AddRange(GenerateFooterOfReception(row + 20, column - 1));
                column += 8;
            }
            return cells;
        }

        private List<ReportSheetCell> GenerateFooterOfReception(int row, int column)
        {
            String[] s1 = { " ", "Entrega\nh74", "Proveedor: Firma y Sello", "\nm2" };
            String[] s2 = { " ", "Recibe\nh73", "Presidenta\nc", "Responsable de Recursos Asociación Creamos\nc\nm2" };
            String[] s3 = { " ", " ", "Myriam Roxana Ponce de León\nc", "Alexandra Navarrete Chacón\nc\nm2" };

            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            ReportSheetCell cell = new ReportSheetCell(row, column, "En señal de conformidad firman:\nc\nm4");
            cells.AddRange(reportSheetController.FillRowWithText(row + 2, column, s1));
            cells.AddRange(reportSheetController.FillRowWithText(row + 4, column, s2));
            cells.AddRange(reportSheetController.FillRowWithText(row + 5, column, s3));
            return cells;
        }
    }
}
