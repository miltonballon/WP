using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SistemaGestorDeInformes
{
    class UserController
    {
        public Connection c = new Connection();

        public UserController()
        {
            c.connect();
        }

        public bool verify(String username, String password)
        {
            User user = null;
            String query = "SELECT * FROM User WHERE name='"+username+"'";
            bool output = false; ;
            try
            {
                SQLiteDataReader data = c.query_show(query);
                if (data.Read())
                {
                    user = new User(Convert.ToString(data[3]), Convert.ToString(data[1]), Convert.ToString(data[2]));
                    output = user.Password.Equals(password);
                }
            }
            catch (Exception)
            {

            }
            return output;
        }

    }
}
