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

        public List<ReportSheetCell> GenerateEnumerateTable(int initialRow, int initialColumn, int heigth,int length)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            for (int row = (initialRow)+1; row <= (initialRow + heigth); row++)
            {
                ReportSheetCell cell = new ReportSheetCell(row,initialColumn,(row-initialRow)+"","c,y");
                cells.Add(cell);
                for (int column = initialColumn + 1; column <= (initialColumn + length); column++)
                {
                    ReportSheetCell emptyCell = new ReportSheetCell(row, column, "","y");
                    cells.Add(emptyCell);
                }
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

        public List<ReportSheetCell> FillTableWithInvoiceRows(int row, int column,List<InvoiceRow> invoiceRows,int numAttributes)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            int tempColumn = column;
            foreach (InvoiceRow invoceRow in invoiceRows)
            {
                String[] attributes = invoceRow.GetAllAttributesAsText();
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

