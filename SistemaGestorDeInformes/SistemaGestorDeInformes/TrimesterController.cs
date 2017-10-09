using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SistemaGestorDeInformes
{
    class TrimesterController
    {
        public Connection c = new Connection();

        public TrimesterController()
        {
            c.connect();
        }

        public void insertTrimester(Trimester trimester)
        {
            String query = "INSERT INTO trimester(open, name) VALUES(";
            int bit = trimester.isOpen() ? 1 : 0;
            String name = trimester.getName();
            query += bit + ", '"+name+"')";
            c.executeInsertion(query);
        }

        public Trimester getLastTrimester()
        {
            Trimester trimester=null;
            String query = "SELECT * FROM trimester WHERE id=(SELECT MAX(id) FROM trimester)";
            SQLiteDataReader data = c.query_show(query);
            if (data.Read())
            {
                trimester = new Trimester(Convert.ToString(data[1]));
                int bit = Convert.ToInt32(data[0]);
                trimester.setOpen(bit==1);
            }
            return trimester;
        }

        public void updateTrimester(Trimester trimester)
        {
            String query = "UPDATE trimester SET open=";
            int bit = trimester.isOpen() ? 1 : 0;
            String name = trimester.getName();
            query += bit + " WHERE name='" + name + "')";
            c.executeInsertion(query);
        }

    }
}
