using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;

namespace ControllerLibrary
{
    class QuotationSheetGenerator
    {
        private TrimesterController trimesterController;
        private InvoiceController invoiceController;
        private ReportSheetController reportSheetController;
        public QuotationSheetGenerator()
        {
            trimesterController = new TrimesterController();
            invoiceController = new InvoiceController();
            reportSheetController = new ReportSheetController();
            //xlWorkSheet.Columns[3].ColumnWidth = 18;
        }
        public ReportSheet GenerateQuotationSheet()
        {
            Trimester ongoingTrimester = trimesterController.getLastTrimester();
            ReportSheet reportSheet = new ReportSheet("cotizacion", "FORMULARIO DE SOLICITUD DE COTIZACION");
            if (ongoingTrimester != null)
            {
                List<Invoice> invoices = invoiceController.getAllInvoicesByTrimester(ongoingTrimester);
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
                String[] headers = { "ITEM", "DESCRIPCION", "UNIDAD", "CANTIDAD", "PRECIO EN BS.", "OBSERVACIONES", "UNITARIO", "TOTAL" };
                String[] text = { "CENTRO:   ASOCIACION CREAMOS", " ", "VIVERES SECOS:", " ", " ", "VIVERES FRESCOS:	" };
                cells.AddRange(reportSheetController.FillRowWithText(row + 2, column, text));
                cells.AddRange(reportSheetController.GenerateEnumerateTable(row + 3, column, 15, headers));
                List<InvoiceRow> invoiceRows = invoices[i].getInvoiceRows();
                cells.AddRange(reportSheetController.FillTableWithInvoiceRows(row + 4, column + 1, invoiceRows, 3));
                cells.AddRange(GenerateFooterOfQuotation(row + 19, column - 1));
                column += 8;
            }
            return cells;
        }

        private List<ReportSheetCell> GenerateFooterOfQuotation(int row, int column)
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
