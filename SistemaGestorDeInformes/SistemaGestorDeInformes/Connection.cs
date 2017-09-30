using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaGestorDeInformes
{
    class Connection
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbCommand command; //para realizar consultas
        private OleDbDataAdapter da;    //para guardar los datos 
        //string ruta = connection.ConnectionString.ToString();
        public Connection()
        {
            
        }
        public void connect()
        {
            try
            {
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/Database.accdb;
                Persist Security Info=False;";
          
                connection.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la BD");
            }
        }
    }
}
