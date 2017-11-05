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
    public class ReportController
    {
        private Connection c;
        private ReportSheetController reportSheetController;
        private readonly int EXCELNOTINSTALLED = -1;
        public ReportController()
        {
            c = new Connection();
            c.connect();
            reportSheetController = new ReportSheetController();
        }

        public int insertReport(Report report, int idTrimester)
        {
            String name = report.Name,
                   date=report.Date.ToString("dd/MM/yyyy");
            String query = "INSERT INTO Report(name, date, id_trimester) VALUES('"+name+"', '"+date+"'," + idTrimester + ")";
            c.executeInsertion(query);
            int id = GetIdByUniqueFields(idTrimester, name);
            report.Id = id;
            reportSheetController.InsertAllReportSheets(report);
            return id;
        }

        public int GetIdByUniqueFields(int idTrimester, String name)
        {
            String query = "SELECT id FROM Report WHERE id_trimester=" + idTrimester + " AND name='" + name + "'";
            return c.FindAndGetID(query);
        }

        public Report GetReportById(int id)
        {
            Report report = null;
            String query = "SELECT * FROM Report WHERE id=" + id;
            SQLiteDataReader data = c.query_show(query);
            if (data.Read())
            {
                String name = data[1].ToString();
                DateTime date = getDate(data[2].ToString());
                List<ReportSheet> reportSheets = reportSheetController.GetAllReportSheetsByReportId(id);
                report = new Report(id, name, date, reportSheets);
            }
            data.Close();
            c.dataClose();
            return report;
        }

        public List<Report> GetAllReportsByTrimesterId(int trimesterId)
        {
            List<Report> reports = new List<Report>();
            String query = "SELECT * FROM Report_sheet WHERE id_trimester=" + trimesterId;
            SQLiteDataReader data = c.query_show(query);
            if (data.Read())
            {
                int id = Int32.Parse(data[0].ToString());
                Report report = GetReportById(id);
                reports.Add(report);
            }
            data.Close();
            c.dataClose();
            return reports;
        }

        private DateTime getDate(String dateString)
        {
            DateTime date;
            string[] dates = dateString.Split('/');
            int day = Int32.Parse(dates[0])
                , month = Int32.Parse(dates[1])
                , year = Int32.Parse(dates[2]);
            date = new DateTime(year, month, day);
            return date;
        }

        public int generateExcel(Report report)
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

                List<ReportSheet> reportSheets = report.Sheets;
                int numSheet = 1;
                List<Worksheet> workSheets=new List<Worksheet>();
                xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(numSheet);
                foreach (ReportSheet reportSheet in reportSheets)
                {
                    xlWorkSheet.Name = reportSheet.Type;
                    fillInExcelCells(reportSheet.Cells, xlWorkSheet);
                    Sheets xlSheets = xlWorkBook.Sheets as Sheets;

                    // The first argument below inserts the new worksheet as the first one
                    xlWorkSheet = (Worksheet)xlSheets.Add(xlSheets[numSheet], Type.Missing, Type.Missing, Type.Missing);
                    //workSheets.Add(xlWorkSheet);
                    numSheet++;
                }

                xlWorkBook.SaveAs("d:\\"+report.Name+".xls", XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
                foreach (Worksheet worksheet in workSheets)
                {
                    Marshal.ReleaseComObject(worksheet);
                }
                Marshal.ReleaseComObject(xlApp);

                output = 0;
            }
            return output;
        }

        private void fillInExcelCells(List<ReportSheetCell> cells, Worksheet workSheet)
        {
            foreach (ReportSheetCell cell in cells)
            {
                int row = cell.Row,
                    column = cell.Column;
                String content = cell.Content,
                       styles=cell.Styles;
                workSheet.Cells[row, column] = content;
                AddStyle(workSheet, row, column, styles);
            }
        }

        private void AddStyle(Worksheet workSheet, int row, int column,string styles)
        {
            int aux;
            if (Util.IsBold(styles))
            {
                workSheet.Cells[row, column].Font.Bold = true;
            }
            aux = Util.GetWidth(styles);
            if (aux>0)
            {
                workSheet.Columns[column].ColumnWidth = aux;
            }

            if (Util.IsCenter(styles))
            {
                workSheet.Cells[row, column].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }
            aux = Util.GetMergeHorizontally(styles);
            if (aux>0)
            {
                workSheet.Range[workSheet.Cells[row, column], workSheet.Cells[row, column+aux]].Merge();
            }
            aux = Util.GetMergeVertically(styles);
            if (aux > 0)
            {
                workSheet.Range[workSheet.Cells[row, column], workSheet.Cells[row+aux, column]].Merge();
            }
            aux = Util.GetHeigth(styles);
            if (aux > 0)
            {
                workSheet.Columns[column].ColumnHeigth = aux;
            }

            if (Util.IsTopBordered(styles))
            {
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            }

            if (Util.IsBottomBordered(styles))
            {
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            }

            if (Util.IsRightBordered(styles))
            {
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            }

            if (Util.IsLeftBordered(styles))
            {
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            }

            if (Util.IsFullBordered(styles))
            {
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            }

            if (Util.IsTopBorderedDot(styles))
            {
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDot;
            }

            if (Util.IsBottomBorderedDot(styles))
            {
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDot;
            }

            if (Util.IsRightBorderedDot(styles))
            {
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDot;
            }

            if (Util.IsLeftBorderedDot(styles))
            {
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDot;
            }

            if (Util.IsFullBorderedDot(styles))
            {
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDot;
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDot;
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDot;
                workSheet.Cells[row, column].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDot;
            }

        }
    }
}
