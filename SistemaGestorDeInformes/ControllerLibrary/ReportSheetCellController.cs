using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using EntityLibrary;
using System.Data;

namespace ControllerLibrary
{
    class ReportSheetCellController
    {
        private Connection c;
        private SQLiteConnection connectionString;
        public ReportSheetCellController()
        {
            c = new Connection();
            c.connect();
            connectionString = c.ConnectionString;
        }

        public int InsertReportSheetCell(ReportSheetCell reportSheetCell, int idReporSheet)
        {
            int row = reportSheetCell.Row,
                column = reportSheetCell.Column;
            String content = reportSheetCell.Content,
                   styles=reportSheetCell.Styles;
            String query = "INSERT INTO Report_sheet_cell(id_report_sheet, row, column, content, styles) VALUES(@IDReportSheet, @row, @column, @content, @styles)";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@IDReportSheet",DbType.Int32);
            command.Parameters.Add("@row",DbType.Int32);
            command.Parameters.Add("@column", DbType.Int32);
            command.Parameters.Add("@content", DbType.String);
            command.Parameters.Add("@styles", DbType.String);
            command.Parameters["@IDReportSheet"].Value = idReporSheet;
            command.Parameters["@row"].Value = row;
            command.Parameters["@column"].Value = column;
            command.Parameters["@content"].Value = content;
            command.Parameters["@styles"].Value = styles;

            c.executeInsertion(command);
            return GetIdByUniqueFields(idReporSheet,row,column);
        }

        public int GetIdByUniqueFields(int idReporSheet, int row, int column)
        {
            String query = "SELECT id FROM Report_sheet_cell WHERE id_report_sheet = @IDReportSheet AND row = @row AND column = @column";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@IDReportSheet", DbType.Int32);
            command.Parameters.Add("@row", DbType.Int32);
            command.Parameters.Add("@column", DbType.Int32);
            command.Parameters["@IDReportSheet"].Value = idReporSheet;
            command.Parameters["@row"].Value = row;
            command.Parameters["@column"].Value = column;

            return c.FindAndGetID(command);
        }

        public void InsertAllReportSheetsCells(ReportSheet reportSheet)
        {
            List<ReportSheetCell> reportSheetsCells = reportSheet.Cells;
            int id = reportSheet.Id;
            foreach (ReportSheetCell reportSheetCell in reportSheetsCells)
            {
                InsertReportSheetCell(reportSheetCell,id);
            }
        }

        public ReportSheetCell GetReportSheetCellById(int id)
        {
            ReportSheetCell reportSheetCell = null;
            String query = "SELECT * FROM Report_sheet_cell WHERE id = @ID";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@ID", DbType.Int32);
            command.Parameters["@ID"].Value = id;

            SQLiteDataReader data=c.query_show(command);
            if (data.Read())
            {
                int row=Int32.Parse(data[2].ToString()), 
                    column= Int32.Parse(data[3].ToString());
                String content = data[4].ToString(),
                       styles= data[5].ToString();
                reportSheetCell = new ReportSheetCell(id,row,column,content,styles);
            }
            data.Close();
            c.dataClose();
            return reportSheetCell;
        }

        public List<ReportSheetCell> GetAllReportSheetsCellsByReportSheetId(int reportSheetId)
        {
            List<ReportSheetCell> reportSheetsCells = new List<ReportSheetCell>();
            String query = "SELECT * FROM Report_sheet_cell WHERE id_report_sheet = @IDReportSheet";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@IDReportSheet", DbType.Int32);
            command.Parameters["@IDReportSheet"].Value = reportSheetId;

            SQLiteDataReader data = c.query_show(command);
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
