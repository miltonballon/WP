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
        public ReportSheetController()
        {
            c = new Connection();
            c.connect();
        }

        public int insertReportSheet(ReportSheet reportSheet, int idReport)
        {

        }
    }
}
