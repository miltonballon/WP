using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;

namespace SistemaGestorDeInformes
{
    class ReportController
    {
        private Connection c;
        private ReportSheetController reportSheetController;
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
            String query = "INSERT INTO Report(name, date, id_trimester) VALUES('"+name+"', '"+date+"'" + idTrimester + ")";
            c.executeInsertion(query);
            int id = getIdByUniqueFields(idTrimester, name);
            report.Id = id;
            reportSheetController.insertAllReportSheets(report);
            return id;
        }

        public int getIdByUniqueFields(int idTrimester, String name)
        {
            String query = "SELECT id FROM Report WHERE id_trimester=" + idTrimester + " AND name='" + name + "'";
            return c.FindAndGetID(query);
        }
    }
}
