using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using EntityLibrary;

namespace SistemaGestorDeInformes
{
    class ReportSheetCellController
    {
        private Connection c;
        public ReportSheetCellController()
        {
            c = new Connection();
            c.connect();
        }

        public int insertReportSheetCell(ReportSheetCell reportSheetCell, int idReporSheet)
        {
            int row = reportSheetCell.Row,
                column = reportSheetCell.Column;
            String content = reportSheetCell.Content;
            String query = "INSERT INTO Report_sheet_cell(id_report_sheet, row, column, content) VALUES("
                +idReporSheet+", "+row+", "+column+" ,'"+content+"')";
            c.executeInsertion(query);
            return getIdByUniqueFields(idReporSheet,row,column);
        }

        public int getIdByUniqueFields(int idReporSheet, int row, int column)
        {
            String query = "SELECT id FROM Report_sheet_cell WHERE id_report_sheet="+idReporSheet+" AND row="+row+" AND column="+column;
            return c.FindAndGetID(query);
        }

        public void insertAllReportSheetsCells(ReportSheet reportSheet)
        {
            List<ReportSheetCell> reportSheetsCells = reportSheet.Cells;
            int id = reportSheet.Id;
            foreach (ReportSheetCell reportSheetCell in reportSheetsCells)
            {
                insertReportSheetCell(reportSheetCell,id);
            }
        }

        public ReportSheetCell GetReportSheetCellById(int id)
        {
            ReportSheetCell reportSheetCell = null;
            String query = "SELECT * FROM Report_sheet_cell WHERE id=" + id;
            SQLiteDataReader data=c.query_show(query);
            if (data.Read())
            {
                int row=Int32.Parse(data[2].ToString()), 
                    column= Int32.Parse(data[3].ToString());
                String content = data[4].ToString();
                reportSheetCell = new ReportSheetCell(id,row,column,content);
            }
            data.Close();
            c.dataClose();
            return reportSheetCell;
        }

        public List<ReportSheetCell> GetAllReportSheetsCellsByReportSheetId(int reportSheetId)
        {
            List<ReportSheetCell> reportSheetsCells = new List<ReportSheetCell>();
            String query = "SELECT * FROM Report_sheet_cell WHERE id_report_sheet=" + reportSheetId;
            SQLiteDataReader data = c.query_show(query);
            if (data.Read())
            {
                int id = Int32.Parse(data[0].ToString());
                ReportSheetCell reportSheetCell = GetReportSheetCellById(id);
                reportSheetsCells.Add(reportSheetCell);
            }
            data.Close();
            c.dataClose();
            return reportSheetsCells;
        }

    }
}
