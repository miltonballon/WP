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
namespace ControllerLibrary
{
    public class Connection
    {

        SQLiteConnection connectionString;
        SQLiteCommand command;
        SQLiteDataReader data;

        public SQLiteConnection ConnectionString { get => connectionString; set => connectionString = value; }

        public SQLiteCommand getCommmand() { return command; }
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
            }
            catch (Exception)
            {

                MessageBox.Show("No se conecto con la BD");
            }
            
        }
        public int FindAndGetID(SQLiteCommand command)
        {
            int answer = -1;
            query_show(command);  
                while (data.Read())
                {
                    string r=data[0].ToString();
                    answer = Int32.Parse(r);
                }
                data.Close();
          return answer;
        }
        
        public SQLiteDataReader query_show(SQLiteCommand com)
        {
            command = com;
            data= command.ExecuteReader();
            return data;
        }
        public void executeInsertion(SQLiteCommand com)
        {
            command = com;
            command.ExecuteNonQuery();  
        }
        public int FindAndGetID(string query)
        {
            int answer = -1;
            string searchQuery = query;
            query_show(searchQuery);
            while (data.Read())
            {
                string r = data[0].ToString();
                answer = Int32.Parse(r);
            }
            data.Close();
            return answer;
        }

        public SQLiteDataReader query_show(string query)
        {
            command = new SQLiteCommand(query, connectionString);
            data = command.ExecuteReader();
            return data;
        }
        public void executeInsertion(string query)
        {
            command = new SQLiteCommand(query, connectionString);
            command.ExecuteNonQuery();
        }

        public void dataClose()
        {
            data.Close();
        }
        
    }
}