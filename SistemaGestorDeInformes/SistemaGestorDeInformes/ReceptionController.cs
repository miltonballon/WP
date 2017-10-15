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
        public void ProductAutoComplete(TextBox Provider)
        {
            string query = "SELECT name FROM Product";

            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Provider.AutoCompleteCustomSource.Add(data["name"].ToString());
               
            }
            c.dataClose();
            data.Close();
          
        }
   
    }
}
