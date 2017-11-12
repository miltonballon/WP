using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Data.SQLite;
using EntityLibrary;

namespace ControllerLibrary
{
    public class ContactController
    {
        private Connection c;
        public ContactController()
        {
            c = new Connection();
            c.connect();
        }

        public int InsertContact(Contact contact, int idProvider)
        {
            String name=contact.Name, 
                   lastName=contact.Lastname, 
                   phone=contact.Phone;
            String query = "INSERT INTO Contact(id_provider, name, last_name, phone) VALUES("+idProvider+",'"+name+"', '"+lastName+"', '"+phone+"')";
            c.executeInsertion(query);
            return GetIdByUniqueFields(idProvider, name, lastName,phone);
        }

        public int GetIdByUniqueFields(int idProvider, String name, String lastName, String phone)
        {
            String query = "SELECT id FROM Contact WHERE id_provider=" + idProvider + " AND name='" + name + "' AND last_name='" + lastName+ "' AND phone='"+phone+"'";
            return c.FindAndGetID(query);
        }

        public Contact GetContactById(int id)
        {
            Contact contact = null;
            String query = "SELECT * FROM Contact WHERE id=" + id;
            SQLiteDataReader data = c.query_show(query);
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
    }
}
