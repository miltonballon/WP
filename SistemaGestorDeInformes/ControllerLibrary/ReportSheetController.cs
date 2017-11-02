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

        public int InsertReportSheet(ReportSheet reportSheet, int idReport)
        {
            String type = reportSheet.Type,
                   tittle=reportSheet.Tittle;
            String query = "INSERT INTO Report_sheet(id_report, type, tittle) VALUES("+idReport+", '"+type+"','"+tittle+"')";
            c.executeInsertion(query);
            int id= GetIdByUniqueFields(idReport, type);
            reportSheet.Id = id;
            reportSheetCellController.InsertAllReportSheetsCells(reportSheet);
            return id;
        }

        public int GetIdByUniqueFields(int idReport, String type)
        {
            String query = "SELECT id FROM Report_sheet WHERE id_report=" + idReport + " AND type='" + type+"'";
            return c.FindAndGetID(query);
        }

        public void InsertAllReportSheets(Report report)
        {
            List<ReportSheet> reportSheets = report.Sheets;
            int id = report.Id;
            foreach (ReportSheet reportSheet in reportSheets)
            {
                InsertReportSheet(reportSheet, id);
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

        public ReportSheet GenerateReferentialPricesSheet()
        {
            Trimester ongoingTrimester = trimesterController.getLastTrimester();
            ReportSheet reportSheet = new ReportSheet("referenciales", "PRECIOS REFERENCIALES");
            if (ongoingTrimester != null)
            {
                List<Invoice> invoices = invoiceController.getAllInvoicesByTrimester(ongoingTrimester);
                List<ReportSheetCell> cells = new List<ReportSheetCell>();
                cells.AddRange(GenerateHeaderAndTableOfReferentialPricesSheet(invoices, reportSheet.Tittle));
                reportSheet.Cells = cells;
            }
            return reportSheet;
        }

        public List<ReportSheetCell> GenerateEnumerateTable(int initialRow, int initialColumn, int heigth, string[] headers)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            cells.AddRange(FillRowWithText(initialRow,initialColumn,headers));
            for (int row = (initialRow)+1; row <= (initialRow + heigth); row++)
            {
                ReportSheetCell cell = new ReportSheetCell(row,initialColumn,(row-initialRow)+"");
                cells.Add(cell);   
            }
            return cells;
        }

        public List<ReportSheetCell> FillRowWithText(int row, int column, string[] headers)
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
                String[] text = { "UNIDAD/CENTRO:", "ASOCIACION CREAMOS"};
                cells.AddRange(FillRowWithText(row + 2, column, text));
                String[]  text1 = { "DOCUMENTO DE REFERENCIA:", "COTIZACIÓN"};
                cells.AddRange(FillRowWithText(row + 3, column, text1));
                String[]  text2 = { "FECHA:", " "};
                cells.AddRange(FillRowWithText(row + 4, column, text2));
                cells.AddRange(GenerateEnumerateTable(row + 5, column, 15, headers));
                List<InvoiceRow> invoiceRows = invoices[i].getInvoiceRows();
                cells.AddRange(FillTableWithInvoiceRows(row + 6, column + 1, invoiceRows, 5));
                cells.AddRange(GenerateFooterOfTableOfReferentialPrices(row + 23, column - 1,invoices[i]));
                cells.AddRange(GenerateFooterOfReferentialPrices(row + 29, column - 1));
                column += 8;
            }
            return cells;
        }

        public List<ReportSheetCell> GenerateFooterOfTableOfReferentialPrices(int row, int column,Invoice invoice)
        {
            double total = invoice.getTotal();
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            String[] text = {"TOTAL",total+""};
            cells.AddRange(FillRowWithText(row, column+5, text));
            row++;
            String spellNumber = Util.NumberToString(total+"");
            String[] text1 = { "Son", spellNumber };
            cells.AddRange(FillRowWithText(row, column, text1));
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

        public List<ReportSheetCell> FillTableWithInvoiceRows(int row, int column,List<InvoiceRow> invoiceRows,int numAttributes)
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

