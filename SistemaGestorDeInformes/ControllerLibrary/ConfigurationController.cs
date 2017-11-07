using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Windows.Forms;

namespace ControllerLibrary
{
    public class ConfigurationController
    {
        public Connection c = new Connection();

        public ConfigurationController()
        {
            c.connect();
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
