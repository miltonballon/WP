using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ControllerLibrary
{
    public class ConfigurationController
    {
        public Connection c = new Connection();

        public ConfigurationController()
        {
            c.connect();
        }

        public Configuration GetConfiguration()
        {
            Configuration configuration=null;
            String query = "SELECT * FROM Configuration WHERE id=1";
            SQLiteDataReader data = c.query_show(query);
            if (data.Read())
            {
                int schollarships = Int32.Parse(data[1].ToString()), 
                    departure = Int32.Parse(data[2].ToString()), 
                    numberDays = Int32.Parse(data[3].ToString()), 
                    minimumQuantity = Int32.Parse(data[4].ToString());
                configuration = new Configuration(schollarships,departure,numberDays,minimumQuantity);
            }
            data.Close();
            c.dataClose();
            return configuration;
        }

        public void insertConfiguration(Configuration configuration)
        {
            /*
            String query = "INSERT INTO configuration(scholarships, n_departure, days_left, minimum_quantity) VALUES(";
            int scholarships = configuration.getScholarships(),
                nDeparture = configuration.getNDeparture(),
                nDaysLeft=configuration.getNDaysLeft(),
                minimumQuantity=configuration.getMinimumQuantity();
            query += scholarships + ", " + nDeparture + ","+nDaysLeft+","+minimumQuantity+")";
            c.executeInsertion(query);
            */

            try
            {
                String Query = "Insert into [Configuration] (scholarships, n_departure, days_left,minimum_quantity) values ('" + configuration.getScholarships() + "', '" + configuration.getNDeparture() + "', '" + configuration.getNDaysLeft() + "', '" + configuration.getMinimumQuantity()+ "')";
                c.executeInsertion(Query);
                

            }
            catch (Exception e)
            {
            }
        }
    }
}
