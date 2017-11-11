using System;
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
        private Connection c = new Connection();
        public ProviderController()
        {
            c.connect();
        }

        public Provider GetProviderById(int id)
        {
            String query = "SELECT * FROM Provider WHERE id="+id;
            SQLiteDataReader data=c.query_show(query);
            Provider provider=null;
            while (data.Read())
            {
                String name = data[1].ToString(), 
                    nit = data[2].ToString();
                provider = new Provider(id, name, nit);
            }
            c.dataClose();
            data.Close();
            return provider;
        }

        public int FindProviderIdByName(String name)
        {
            String query = "SELECT id FROM Provider WHERE name='"+name+"'";
            int idProvider= c.FindAndGetID(query);
            return idProvider;
        }

        public int InsertProvider(Provider provider)
        {
            String name = provider.GetName(),
                nit = provider.GetNit();
            String query = "INSERT INTO Provider(name, NIT) VALUES ('"+name+"','"+nit+"')";
            c.executeInsertion(query);
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
            String query = "UPDATE Provider SET name='";
            String name = provider.GetName(),
            NIT = provider.GetNit() ;
            int id = provider.GetId();
            query += name + "', NIT='"+NIT+"' WHERE id=" + id + "";
            c.executeInsertion(query);
        }
    }
}
