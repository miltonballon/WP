using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Data.SQLite;

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
    }
}
