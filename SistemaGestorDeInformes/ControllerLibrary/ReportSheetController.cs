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
        private InvoiceController invoiceController;
        private TrimesterController trimesterController;
        private readonly int EXCELNOTINSTALLED=-1;
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
                int total = invoices.Count;
                List<ReportSheetCell> cells = new List<ReportSheetCell>();
                cells.AddRange(generateHeader(total, reportSheet.Tittle));
                String[] headers = {"ITEM", "DESCRIPCION", "UNIDAD", "CANTIDAD", "PRECIO EN BS.", "OBSERVACIONES", "UNITARIO", "TOTAL"};
                cells.AddRange(generateEnumerateTable(8, 1, 15, headers));
                reportSheet.Cells = cells;
            }
            return reportSheet;
        }

        private List<ReportSheetCell> generateEnumerateTable(int initialRow, int initialColumn, int heigth, string[] headers)
        {
            List<ReportSheetCell> cells = new List<ReportSheetCell>();
            cells.AddRange(generateHeaderOfTable(initialRow,initialColumn,headers));
            for (int row = (initialRow)+1; row <= (initialRow + heigth); row++)
            {
                ReportSheetCell cell = new ReportSheetCell(row,initialColumn,(row-initialRow)+"");
                cells.Add(cell);   
            }
            return cells;
        }

        private List<ReportSheetCell> generateHeaderOfTable(int row, int column, string[] headers)
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

        private List<ReportSheetCell> generateHeader(int numberCopies, String title)
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
                row += 2;
                cells.Add(cell);
                cell = new ReportSheetCell(row, column, title);
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

