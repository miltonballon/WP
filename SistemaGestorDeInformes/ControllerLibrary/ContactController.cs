using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Data.SQLite;
using System.Data;

namespace ControllerLibrary
{
    public class ContactController
    {
        private Connection c;
        private SQLiteConnection connectionString;
        public ContactController()
        {
            c = new Connection();
            c.connect();
            connectionString = c.ConnectionString;
        }

        public int InsertContact(Contact contact, int idProvider)
        {
            String name=contact.Name, 
                   lastName=contact.Lastname, 
                   phone=contact.Phone;
            String query = "INSERT INTO Contact(id_provider, name, last_name, phone) VALUES(@IDProv, @name, @last_name, @phone)";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@IDProv", DbType.Int32);
            command.Parameters.Add("@name", DbType.String);
            command.Parameters.Add("@last_name", DbType.String);
            command.Parameters.Add("@phone", DbType.String);
            command.Parameters["@IDProv"].Value = idProvider;
            command.Parameters["@name"].Value = name;
            command.Parameters["@last_name"].Value = lastName;
            command.Parameters["@phone"].Value = phone;

            c.executeInsertion(command);
            return GetIdByUniqueFields(idProvider, name, lastName,phone);
        }

        public int GetIdByUniqueFields(int idProvider, String name, String lastName, String phone)
        {
            String query = "SELECT id FROM Contact WHERE id_provider = @IDProv AND name = @name AND last_name = @last_name AND phone = @phone";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@IDProv", DbType.Int32);
            command.Parameters.Add("@name", DbType.String);
            command.Parameters.Add("@last_name", DbType.String);
            command.Parameters.Add("@phone", DbType.String);
            command.Parameters["@IDProv"].Value = idProvider;
            command.Parameters["@name"].Value = name;
            command.Parameters["@last_name"].Value = lastName;
            command.Parameters["@phone"].Value = phone;

            return c.FindAndGetID(command);
        }

        public Contact GetContactById(int id)
        {
            Contact contact = null;
            String query = "SELECT * FROM Contact WHERE id = @ID";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@ID", DbType.Int32);
            command.Parameters["@ID"].Value = id;

            SQLiteDataReader data = c.query_show(command);
            if (data.Read())
            {
                String name=data[1].ToString(), 
                       lastName = data[2].ToString(), 
                       phone = data[3].ToString();
                contact = new Contact(id,name,lastName,phone);
            }
            data.Close();
            c.dataClose();
            return contact;
        }

        public void UpdateContact(Contact contact)
        {
            int id = contact.Id;
            String name=contact.Name, 
                   lastName=contact.Lastname, 
                   phone=contact.Phone;
            String query = "UPDATE Contact SET name = @name, last_name = @last_name, phone = @phone WHERE id = @ID";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@ID", DbType.Int32);
            command.Parameters.Add("@name", DbType.Int32);
            command.Parameters.Add("@last_name", DbType.Int32);
            command.Parameters.Add("@phone", DbType.Int32);
            command.Parameters["@ID"].Value = id;
            command.Parameters["@name"].Value = name;
            command.Parameters["@last_name"].Value = lastName;
            command.Parameters["@phone"].Value = phone;

            c.executeInsertion(command);
        }
    }
}
