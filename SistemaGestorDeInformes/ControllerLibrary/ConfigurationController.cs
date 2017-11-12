using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace ControllerLibrary
{
    public class ConfigurationController
    {
        public Connection c;
        private SQLiteConnection connectionString;
        public ConfigurationController()
        {
            c = new Connection();
            c.connect();
            connectionString = c.ConnectionString;
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
            String query = "INSERT INTO configuration(scholarships, n_departure, days_left, minimum_quantity) VALUES(@schollar, @n_depar, @days, @minimum)";
            int scholarships = configuration.getScholarships(),
                nDeparture = configuration.getNDeparture(),
                nDaysLeft=configuration.getNDaysLeft(),
                minimumQuantity=configuration.getMinimumQuantity();

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@schollar", DbType.String);
            command.Parameters.Add("@n_depar", DbType.String);
            command.Parameters.Add("@days", DbType.String);
            command.Parameters.Add("@minimum", DbType.String);
            command.Parameters["@schollar"].Value = scholarships;
            command.Parameters["@n_depar"].Value = nDeparture;
            command.Parameters["@days"].Value = nDaysLeft;
            command.Parameters["@minimum"].Value = minimumQuantity;

            c.executeInsertion(command);
        }
    }
}
