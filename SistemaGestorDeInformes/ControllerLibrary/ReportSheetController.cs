using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Data.SQLite;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ControllerLibrary
{
    public class ReportSheetController
    {
        private Connection c;
        private ReportSheetCellController reportSheetCellController;
        private readonly int EXCELNOTINSTALLED=-1;
        public ReportSheetController()
        {
            c = new Connection();
            c.connect();
            reportSheetCellController = new ReportSheetCellController();
        }

        public int insertReportSheet(ReportSheet reportSheet, int idReport)
        {
            String type = reportSheet.Type;
            String query = "INSERT INTO Report_sheet(id_report, type) VALUES("+idReport+", '"+type+"')";
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
                String type = data[2].ToString();
                List<ReportSheetCell> reportSheetsCells = reportSheetCellController.GetAllReportSheetsCellsByReportSheetId(id);
                reportSheet = new ReportSheet(id, type, reportSheetsCells);
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
            ReportSheet reportSheet = new ReportSheet("Cotizacion");
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            cells.AddRange(generateHeaderQuotationSheet(3));
            reportSheet.Cells = cells;
            return reportSheet;
        }

        private List<ReportSheetCell> generateHeaderQuotationSheet(int numberCopies)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            int row, 
                column=1;
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
                row++;
                cells.Add(cell);
                column += 7;
            }
            return cells;
        }

        public int generateExcelSheet(ReportSheet reportSheet)
        {
            int output;
            Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                output = EXCELNOTINSTALLED;
            }
            else
            {
                Workbook xlWorkBook;
                Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Name = reportSheet.Type;
                fillInExcelCells(reportSheet.Cells,xlWorkSheet);

                xlWorkBook.SaveAs("d:\\csharp-Excel.xls", XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);

                output = 0;
            }
            return output;
        }

        private void fillInExcelCells(List<ReportSheetCell> cells, Worksheet workSheet)
        {
            foreach (ReportSheetCell cell in cells)
            {
                int row=cell.Row, 
                    column=cell.Column;
                String content = cell.Content;
                workSheet.Cells[row, column] = content;
            }
        }
    }
}

