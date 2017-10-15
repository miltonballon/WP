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
        public void ProductAutoComplete(TextBox Product)
        {
            string query = "SELECT name FROM Product";

            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Product.AutoCompleteCustomSource.Add(data["name"].ToString());
               
            }
            c.dataClose();
            data.Close();     
        }
        public void ProviderAutoComplete(TextBox Provider)
        {
            string query = "SELECT Provider FROM Provider";

            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Provider.AutoCompleteCustomSource.Add(data["Provider"].ToString());
            }
            c.dataClose();
            data.Close();
        }
        public void UnitAutoComplete(TextBox Unit)
        {
            string query = "SELECT Type FROM Unit";

            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Unit.AutoCompleteCustomSource.Add(data["Type"].ToString());
            }
            c.dataClose();
            data.Close();
        }
       
   
    }
}
