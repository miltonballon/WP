﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using EntityLibrary;

namespace ControllerLibrary
{
    public class TrimesterController
    {
        private Connection c;
        private SQLiteConnection connectionString;

        public TrimesterController()
        {
            c = new Connection();
            c.connect();
            connectionString = c.ConnectionString;
        }

        public void InsertTrimester(Trimester trimester)
        {
            String query = "INSERT INTO trimester(open, name,initial_date,end_date) VALUES(@open, @name, @initial, @end)";
            int bit = trimester.IsOpen() ? 1 : 0;
            String name = trimester.GetName(),
                   initialDate =trimester.InitialDate.ToString("dd/MM/yyyy"),
                   endDate = trimester.EndDate.ToString("dd/MM/yyyy");

            SQLiteCommand command = new SQLiteCommand(query,connectionString);
            command.Parameters.Add("@open",DbType.Int32);
            command.Parameters.Add("@name",DbType.String);
            command.Parameters.Add("@initial", DbType.String);
            command.Parameters.Add("@end", DbType.String);
            command.Parameters["@open"].Value = bit;
            command.Parameters["@name"].Value = name;
            command.Parameters["@initial"].Value = initialDate;
            command.Parameters["@end"].Value = endDate;

            c.executeInsertion(command);
        }

        public List<Trimester> GetLastTwoTrimester()
        {
            List<Trimester> trimesters = new List<Trimester>();
            String query = "SELECT * FROM trimester WHERE id=(SELECT MAX(id) FROM trimester)";
            SQLiteDataReader data = c.query_show(query);
            int id=0;
            if (data.Read())
            {
                id = Int32.Parse(data[0].ToString());
            }
            data.Close();
            c.dataClose();
            for (int i = 1; i <= 2; i++)
            {
                Trimester trimester = GetTrimesterById(id - i);
                if (trimester != null)
                {
                    trimesters.Add(trimester);
                }
            }
            return trimesters;
        }

        public Trimester GetTrimesterById(int id)
        {
            Trimester trimester = null;
            String query = "SELECT * FROM trimester WHERE id = @ID";
            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@ID", DbType.Int32);
            command.Parameters["@ID"].Value = id;
            SQLiteDataReader data = c.query_show(command);
            if (data.Read())
            {
                String name = data[2].ToString();
                int bit = Int32.Parse(data[1].ToString());
                DateTime initialDate=Util.GetDate(data[3].ToString()), 
                         endDate = Util.GetDate(data[4].ToString());
                trimester = new Trimester(id, name,initialDate,endDate);
                trimester.SetOpen(bit == 1);
            }
            data.Close();
            c.dataClose();
            return trimester;
        }

        public Trimester GetLastTrimester()
        {
            Trimester trimester=null;
            String query = "SELECT * FROM trimester WHERE id=(SELECT MAX(id) FROM trimester)";
            SQLiteDataReader data = c.query_show(query);
            if (data.Read())
            { 
                int id = Int32.Parse(data[0].ToString());
                trimester = GetTrimesterById(id);
            }
            data.Close();
            c.dataClose();
            return trimester;
        }

        public void UpdateTrimester(Trimester trimester)
        {
            String query = "UPDATE trimester SET open = @open WHERE id = @ID";
            int bit = trimester.IsOpen() ? 1 : 0;
            int id = trimester.GetId();

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@ID", DbType.Int32);
            command.Parameters.Add("@open", DbType.Int32);
            command.Parameters["@ID"].Value = id;
            command.Parameters["@open"].Value = bit;

            c.executeInsertion(command);
        }

    }
}
