using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
namespace SistemaGestorDeInformes
{
    class Connection
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbCommand command; //para realizar consultas
        private OleDbDataAdapter da;    //para guardar los datos 

        public OleDbCommand getCommmand() { return command; }

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
                //MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se conecto con la BD");
            }
        }
        public int buscarYDevolverId(string consulta)
        {
            int respuesta = -1;
            string searchQuery = consulta;
            executeQuery(searchQuery);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    respuesta = reader.GetInt32(0);
                }
            }
            return respuesta;

        }

        public OleDbDataAdapter executeQuery(string consulta)
        {
            command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = consulta;
            da = new OleDbDataAdapter(command);
            return da;
        }
        public void executeInsertion(string consulta)
        {

            command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = consulta;
            command.ExecuteNonQuery();


        }
        public void connectionOpen()
        {
            connection.Open();
        }
        public void connectionClose()
        {
            connection.Close();
        }
        public void clearTextBox()
        {
            da = null;
        }
    }
}