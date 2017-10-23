using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SistemaGestorDeInformes
{
    public class TrimesterController
    {
        private Connection c = new Connection();

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
                String name = data[2].ToString();
                int bit = Int32.Parse(data[1].ToString()), 
                    id = Int32.Parse(data[0].ToString());
                trimester = new Trimester(id,name);
                trimester.setOpen(bit==1);
            }
            data.Close();
            c.dataClose();
            return trimester;
        }

        public void updateTrimester(Trimester trimester)
        {
            String query = "UPDATE trimester SET open=";
            int bit = trimester.isOpen() ? 1 : 0;
            int id = trimester.getId();
            query += bit + " WHERE id='" + id + "'";
            c.executeInsertion(query);
        }

    }
}
