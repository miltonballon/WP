using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class ConfigurationController
    {
        public Connection c = new Connection();

        public ConfigurationController()
        {
            c.connect();
        }

        public void insertConfiguration(Configuration configuration)
        {
            String query = "INSERT INTO configuration(scholarships, n_departure) VALUES(";
            int scholarships = configuration.getScholarships();
            int nDeparture = configuration.getNDeparture();
            query += scholarships + ", " + nDeparture + ")";
            c.executeInsertion(query);
        }
    }
}
