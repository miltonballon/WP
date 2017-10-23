﻿using System;
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

    }
}
