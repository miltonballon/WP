using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using EntityLibrary;

namespace ControllerLibrary
{
    public class UserController
    {
        public Connection c;
        private SQLiteConnection connectionString;
        public UserController()
        {
            c = new Connection();
            c.connect();
            connectionString = c.ConnectionString;
        }

        public bool verify(String username, String password)
        {
            User user = null;
            String query = "SELECT * FROM User WHERE name = @username";
            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@username", DbType.String);
            command.Parameters["@username"].Value = username;
            bool output = false; ;
            try
            {
                SQLiteDataReader data = c.query_show(command);
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
            String query = "SELECT * FROM User WHERE name = @username";
            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@username", DbType.String);
            command.Parameters["@username"].Value = username;
            try
            {
                SQLiteDataReader data = c.query_show(command);
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
            String username=user.Name, 
                   password=user.Password, 
                   email=user.Password;
            try
            {
                String query = "Insert into User (name, password, email) values (@username, @password, @email )";
                SQLiteCommand command = new SQLiteCommand(query, connectionString);
                command.Parameters.Add("@username", DbType.String);
                command.Parameters.Add("@password", DbType.String);
                command.Parameters.Add("@email", DbType.String);
                command.Parameters["@username"].Value = username;
                command.Parameters["@password"].Value = password;
                command.Parameters["@email"].Value = email;

                c.executeInsertion(command);
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
