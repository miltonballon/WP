using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Data.SQLite;

namespace ControllerLibrary
{
    class ContactController
    {
        private Connection c;
        public ContactController()
        {
            c = new Connection();
            c.connect();
        }
    }
}
