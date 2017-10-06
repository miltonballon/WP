using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
namespace SistemaGestorDeInformes
{
    class Connection
    {

        SQLiteConnection connectionString;
        SQLiteCommand comando;
        SQLiteDataReader data;
        public SQLiteCommand getCommmando() { return comando; }
        public SQLiteDataReader getData() { return data; }
        public Connection()
        {

        }


        public void connect()
        {
            try
            {
                connectionString = new SQLiteConnection("Data Source = Database/Database.db");
                connectionString.Open();
               // MessageBox.Show("Conectado SQLITE");
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
            mostrarconsulta(searchQuery);  
                while (data.Read())
                {
                    string r=data[0].ToString();
                    respuesta = Int32.Parse(r);
                }
           
            return respuesta;
            

        }
        
        public SQLiteDataReader mostrarconsulta(string consulta)
        {

            comando = new SQLiteCommand(consulta, connectionString);
            data= comando.ExecuteReader();
            return data;
        }
        public void executeInsertion(string consulta)
        {
            comando = new SQLiteCommand(consulta, connectionString);
            comando.ExecuteNonQuery();

        }
       
    }
}