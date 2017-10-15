using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace SistemaGestorDeInformes
{
    class ReceptionController
    {

        private Connection c = new Connection();
        public ReceptionController()
        {
            c.connect();
        }

   
    }
}
