using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class Configuration
    {
        private int scholarships;
        private int nDeparture;

        public Configuration(int scholarships, int nDeparture)
        {
            this.scholarships = scholarships;
            this.nDeparture = nDeparture;
        }

        public void setScholarships(int scholarships)
        {
            this.scholarships = scholarships;
        }

        public void setNDeparture(int nDeparture)
        {
            this.nDeparture = nDeparture;
        }

        public int getScholarships()
        {
            return scholarships;
        }

        public int getNDeparture()
        {
            return nDeparture;
        }

        public Configuration()
        {
        }

        public override String ToString()
        {
            return "Becas: " + scholarships + " N.Partida: " + nDeparture;
        }
    }
}
