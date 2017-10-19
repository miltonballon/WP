using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SistemaGestorDeInformes
{
    public class UserController
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
                data.Close();
                c.dataClose();
            }
            catch (Exception)
            {

            }
            return output;
        }

        public User getUserByUsername(String username)
        {
            User user = null;
            String query = "SELECT * FROM User WHERE name='" + username + "'";
            try
            {
                SQLiteDataReader data = c.query_show(query);
                if (data.Read())
                {
                    user = new User(Convert.ToString(data[3]), Convert.ToString(data[1]), Convert.ToString(data[2]));
                }
                data.Close();
                c.dataClose();
            }
            catch (Exception)
            {

            }
            return user;
        }
        public bool CreateUser(User user)
        {
          
            try
            {
                String Query = "Insert into [User] (name, password, email) values ('"+user.Name+"', '"+user.Password+"', '"+user.Email+"' )";
                c.executeInsertion(Query);
              return  true;
            
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool HasUser()
        {
            String query = "SELECT * FROM User";
        
                SQLiteDataReader data = c.query_show(query);
                if (data.Read())
                {
                    //si hay datos devolver true
                    data.Close();
                    c.dataClose();
                    return true;
                }
                else
                {
                    data.Close();
                    c.dataClose();
                    return false;
                }

        }
    }
}
