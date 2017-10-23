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

        public int insertReportSheetCell(ReportSheetCell reportSheetCell)
        {

        }

    }
}
