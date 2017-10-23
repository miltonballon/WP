using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
