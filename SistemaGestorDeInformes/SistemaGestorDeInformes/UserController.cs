using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class UserController
    {
        public Connection c = new Connection();

        public UserController()
        {
            c.connect();
        }

        public bool verify(String username)
        {

        }

    }
}
