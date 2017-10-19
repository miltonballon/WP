using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    public class ProviderController
    {
        private Connection c = new Connection();
        public ProviderController()
        {
            c.connect();
        }

        public Provider getProviderById(int id)
        {
            String query = "SELECT * FROM Provider WHERE id="+id;
            SQLiteDataReader data=c.query_show(query);
            Provider provider=null;
            while (data.Read())
            {
                String name = data[1].ToString();
                int nit = Int32.Parse(data[2].ToString());
                provider = new Provider(name, nit);
            }
            c.dataClose();
            data.Close();
            return provider;
        }

        public int findProviderIdByName(String name)
        {
            String query = "SELECT id FROM Provider WHERE Provider='"+name+"'";
            int idProvider= c.FindAndGetID(query);
            return idProvider;
        }

        public int insertProvider(Provider provider)
        {
            String name = provider.getName();
            int nit = provider.getNit();
            String query = "INSERT INTO Provider(Provider, NIT) VALUES ('"+name+"',"+nit+")";
            c.executeInsertion(query);
            int idProvider = findProviderIdByName(name);
            return idProvider;
        }

        public List<Provider> getAllProviders()
        {
            List<Provider> output = new List<Provider>();
            string query = "SELECT * FROM Provider";
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                String name = data[1].ToString();
                int nit = Int32.Parse(data[2].ToString());
                Provider provider = new Provider(name, nit);
                output.Add(provider);
            }
            data.Close();
            c.dataClose();
            return output;
        }
    }

}
