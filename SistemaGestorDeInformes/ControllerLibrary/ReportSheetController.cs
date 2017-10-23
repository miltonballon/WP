using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;

namespace SistemaGestorDeInformes
{
    class ReportSheetController
    {
        private Connection c;
        private ReportSheetCellController reportSheetCellController;
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
    }
}
