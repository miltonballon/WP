using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;

namespace ControllerLibrary
{
    public class ProviderController
    {
        private Connection c;
        private SQLiteConnection connectionString;
        public ProviderController()
        {
            c = new Connection();
            c.connect();
            connectionString = c.ConnectionString;
        }
        public Provider GetProviderById(int id)
        {
            String query = "SELECT * FROM Provider WHERE id = @ID";
            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@ID", DbType.Int32);
            command.Parameters["@ID"].Value = id;
            SQLiteDataReader data=c.query_show(command);
            Provider provider=null;
            while (data.Read())
            {
                String name = data[1].ToString(), 
                    nit = data[2].ToString(),
                    address= data[3].ToString();
                provider = new Provider(id, name, nit,address);
            }
            c.dataClose();
            data.Close();
            return provider;
        }
        public int FindProviderIdByName(String name)
        {
            String query = "SELECT id FROM Provider WHERE name = @name";
            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@name", DbType.String);
            command.Parameters["@name"].Value = name;
            int idProvider= c.FindAndGetID(command);
            return idProvider;
        }
        public int InsertProvider(Provider provider)
        {
            String name = provider.GetName(),
                nit = provider.GetNit(),
                address=provider.GetAddress();
            String query = "INSERT INTO Provider(name, NIT, address) VALUES (@name, @NIT, @address)";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@name", DbType.String);
            command.Parameters.Add("@NIT", DbType.String);
            command.Parameters.Add("@address", DbType.String);
            command.Parameters["@name"].Value = name;
            command.Parameters["@NIT"].Value = nit;
            command.Parameters["@address"].Value = address;

            c.executeInsertion(command);
            int idProvider = FindProviderIdByName(name);
            return idProvider;
        }
        public List<Provider> GetAllProviders()
        {
            List<Provider> output = new List<Provider>();
            string query = "SELECT * FROM Provider";
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                int id = Int32.Parse(data[0].ToString());
                Provider provider = GetProviderById(id);
                output.Add(provider);
            }
            data.Close();
            c.dataClose();
            return output;
        }
        public int ForceSearchProvider(Provider provider)
        {
            int id = FindProviderIdByName(provider.GetName());
            if (id < 0)
            {
                InsertProvider(provider);
            }
            return id;
        }
        public void updateProvider(Provider provider)
        {
            String query = "UPDATE Provider SET name=@name, NIT=@NIT, address=@address WHERE id=@ID";
            String name = provider.GetName(),
                   nit = provider.GetNit(),
                   address=provider.GetAddress();
            int id = provider.GetId();

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@name", DbType.String);
            command.Parameters.Add("@NIT", DbType.String);
            command.Parameters.Add("@address", DbType.String);
            command.Parameters.Add("@ID", DbType.Int32);
            command.Parameters["@name"].Value = name;
            command.Parameters["@NIT"].Value = nit;
            command.Parameters["@address"].Value = address;
            command.Parameters["@ID"].Value = id;

            c.executeInsertion(command);
        }
    }
}
