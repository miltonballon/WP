using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;

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
            String query = "INSERT INTO configuration(scholarships, n_departure, days_left, minimum_quantity) VALUES(";
            int scholarships = configuration.getScholarships(),
                nDeparture = configuration.getNDeparture(),
                nDaysLeft=configuration.getNDaysLeft(),
                minimumQuantity=configuration.getMinimumQuantity();
            query += scholarships + ", " + nDeparture + ","+nDaysLeft+","+minimumQuantity+")";
            c.executeInsertion(query);
        }
    }
}
