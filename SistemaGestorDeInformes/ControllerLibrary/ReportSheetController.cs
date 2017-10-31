using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Data.SQLite;

namespace ControllerLibrary
{
    public class ReportSheetController
    {
        private Connection c;
        private ReportSheetCellController reportSheetCellController;
        private InvoiceController invoiceController;
        private TrimesterController trimesterController;
        public ReportSheetController()
        {
            c = new Connection();
            c.connect();
            reportSheetCellController = new ReportSheetCellController();
            invoiceController = new InvoiceController();
            trimesterController = new TrimesterController();
        }

        public int insertReportSheet(ReportSheet reportSheet, int idReport)
        {
            String type = reportSheet.Type,
                   tittle=reportSheet.Tittle;
            String query = "INSERT INTO Report_sheet(id_report, type, tittle) VALUES("+idReport+", '"+type+"','"+tittle+"')";
            c.executeInsertion(query);
            int id= getIdByUniqueFields(idReport, type);
            reportSheet.Id = id;
            reportSheetCellController.insertAllReportSheetsCells(reportSheet);
            return id;
        }

        public int getIdByUniqueFields(int idReport, String type)
        {
            String query = "SELECT id FROM Report_sheet WHERE id_report=" + idReport + " AND type='" + type+"'";
            return c.FindAndGetID(query);
        }

        public void insertAllReportSheets(Report report)
        {
            List<ReportSheet> reportSheets = report.Sheets;
            int id = report.Id;
            foreach (ReportSheet reportSheet in reportSheets)
            {
                insertReportSheet(reportSheet, id);
            }
        }

        public ReportSheet GetReportSheetById(int id)
        {
            ReportSheet reportSheet = null;
            String query = "SELECT * FROM Report_sheet WHERE id=" + id;
            SQLiteDataReader data = c.query_show(query);
            if (data.Read())
            {
                String type = data[2].ToString(),
                       tittle= data[3].ToString();
                List<ReportSheetCell> reportSheetsCells = reportSheetCellController.GetAllReportSheetsCellsByReportSheetId(id);
                reportSheet = new ReportSheet(id, type, tittle,reportSheetsCells);
            }
            data.Close();
            c.dataClose();
            return reportSheet;
        }

        public List<ReportSheet> GetAllReportSheetsByReportId(int reportId)
        {
            List<ReportSheet> reportSheets = new List<ReportSheet>();
            String query = "SELECT * FROM Report_sheet WHERE id_report=" + reportId;
            SQLiteDataReader data = c.query_show(query);
            if (data.Read())
            {
                int id = Int32.Parse(data[0].ToString());
                ReportSheet reportSheet = GetReportSheetById(id);
                reportSheets.Add(reportSheet);
            }
            data.Close();
            c.dataClose();
            return reportSheets;
        }

        public ReportSheet generateQuotationSheet()
        {
            Trimester ongoingTrimester = trimesterController.getLastTrimester();
            ReportSheet reportSheet = new ReportSheet("cotizacion", "FORMULARIO DE SOLICITUD DE COTIZACION");
            if (ongoingTrimester != null)
            {
                List<Invoice> invoices = invoiceController.getAllInvoicesByTrimester(ongoingTrimester);
                List<ReportSheetCell> cells = new List<ReportSheetCell>();
                cells.AddRange(generateHeaderAndTableOfQuotation(invoices, reportSheet.Tittle));
                reportSheet.Cells = cells;
            }
            return reportSheet;
        }

        public ReportSheet generateReferentialPricesSheet()
        {
            Trimester ongoingTrimester = trimesterController.getLastTrimester();
            ReportSheet reportSheet = new ReportSheet("referenciales", "PRECIOS REFERENCIALES");
            if (ongoingTrimester != null)
            {
                List<Invoice> invoices = invoiceController.getAllInvoicesByTrimester(ongoingTrimester);
                List<ReportSheetCell> cells = new List<ReportSheetCell>();
                cells.AddRange(generateHeaderAndTableOfQuotation(invoices, reportSheet.Tittle));
                reportSheet.Cells = cells;
            }
            return reportSheet;
        }

        private List<ReportSheetCell> generateEnumerateTable(int initialRow, int initialColumn, int heigth, string[] headers)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            cells.AddRange(fillRowWithText(initialRow,initialColumn,headers));
            for (int row = (initialRow)+1; row <= (initialRow + heigth); row++)
            {
                ReportSheetCell cell = new ReportSheetCell(row,initialColumn,(row-initialRow)+"");
                cells.Add(cell);   
            }
            return cells;
        }

        private List<ReportSheetCell> fillRowWithText(int row, int column, string[] headers)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            for (int i=0;i<headers.Length;i++)
            {
                ReportSheetCell cell=new ReportSheetCell(row, column, headers[i]);
                cells.Add(cell);
                column++;
            }
            return cells;
        }

        /*private ReportSheetCell generateCellWithText(int row, int column, String text)
        {
            ReportSheetCell reportSheetCell;

            return reportSheetCell;
        }*/

        private List<ReportSheetCell> generateHeaderAndTableOfQuotation(List<Invoice> invoices, String title)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            int row=0, 
                column=1;
            int numberCopies = invoices.Count;
            for (int i=0;i<numberCopies; i++)
            {
                row = 1;
                ReportSheetCell cell = new ReportSheetCell(row,column,i+"");
                cells.Add(cell);
                column++;
                cell = new ReportSheetCell(row,column, "GOBIERNO AUTONOMO DEPARTAMENTAL");
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
                cells.Add(cell);
                column += 7;
            }
            column = 2;
            for (int i = 0; i < numberCopies; i++)
            {
                String[] headers = { "ITEM", "DESCRIPCION", "UNIDAD", "CANTIDAD", "PRECIO EN BS.", "OBSERVACIONES", "UNITARIO", "TOTAL" };
                String[] text = { "CENTRO:   ASOCIACION CREAMOS", " ", "VIVERES SECOS:", " ", " ", "VIVERES FRESCOS:	" };
                cells.AddRange(fillRowWithText(row+2,column,text));
                cells.AddRange(generateEnumerateTable(row+3, column, 15, headers));
                List<InvoiceRow> invoiceRows = invoices[i].getInvoiceRows();
                cells.AddRange(fillTableWithInvoiceRows(row + 4, column+1, invoiceRows, 3));
                cells.AddRange(generateFooterOfQuotation(row + 19, column-1));
                column += 8;
            }
            return cells;
        }

        private List<ReportSheetCell> generateFooterOfQuotation(int row, int column)
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

        private List<ReportSheetCell> fillTableWithInvoiceRows(int row, int column,List<InvoiceRow> invoiceRows,int numAttributes)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            int tempColumn = column;
            foreach (InvoiceRow invoceRow in invoiceRows)
            {
                String[] attributes = invoceRow.getAllAttributesAsText();
                for (int i=0;i<numAttributes;i++)
                {
                    String text = attributes[i];
                    ReportSheetCell cell = new ReportSheetCell(row, tempColumn, text);
                    tempColumn++;
                    cells.Add(cell);
                }
                row++;
                tempColumn = column;
            }
            return cells;
        }
    }
}

