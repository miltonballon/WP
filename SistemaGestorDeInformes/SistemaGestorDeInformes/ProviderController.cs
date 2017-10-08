using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class ProviderController
    {
        public Connection c = new Connection();
        public ProviderController()
        {
            c.connect();
        }

        public Provider getProviderById(int id)
        {
            String query = "SELECT * FROM Provider WHERE id="+id;
            SQLiteDataReader data=c.query_show(query);
            Provider provider = new Provider(data[1].ToString(),Int32.Parse(data[2].ToString()));
            return provider;
        }

        public int findProviderIdByName(String name)
        {
            String query = "SELECT id FROM Provider WHERE Provider='"+name+"'";
            return c.FindAndGetID(query);
        }

        public int insertProvider(Provider provider)
        {
            String name = provider.getName();
            int nit = provider.getNit();
            String query = "INSERT INTO Provider(Provider, NIT) VALUES ('"+name+"',"+nit+")";
            c.executeInsertion(query);
            return findProviderIdByName(name);
        }

        public List<Provider> getAllProviders()
        {
            List<Provider> output = new List<Provider>();
            string query = "SELECT * FROM Provider";
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Provider provider = new Provider(data[1].ToString(), Int32.Parse(data[2].ToString()));
                output.Add(provider);
            }
            return output;
        }

        /*public int updateProviderById(int id, Provider provider)
        {
            String name = provider.getName();
            int nit = provider.getNit();
            String query = "UPDATE Provider SET Provider='"+name+"',NIT="+nit+" WHERE id="+id;
            c.
        }*/
    }

}
