using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Configuration
    {
        private int scholarships;
        private int nDeparture;
        private int nDaysLeft;
        private int minimumQuantity;

        public Configuration(int scholarships, int nDeparture)
        {
            this.scholarships = scholarships;
            this.nDeparture = nDeparture;
        }

        public Configuration(int scholarships, int nDeparture, int nDaysLeft, int minimumQuantity)
        {
            this.scholarships = scholarships;
            this.nDeparture = nDeparture;
            this.nDaysLeft = nDaysLeft;
            this.minimumQuantity = minimumQuantity;
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

        public int getNDaysLeft()
        {
            return nDaysLeft;
        }

        public void setNDaysLeft(int nDaysLeft)
        {
            this.nDaysLeft = nDaysLeft;
        }

        public int getMinimumQuantity()
        {
            return minimumQuantity;
        }

        public void setMinimumQuantity(int minimumQuantity)
        {
            this.minimumQuantity = minimumQuantity;
        }

        public override String ToString()
        {
            return "Becas: " + scholarships + " N.Partida: " + nDeparture;
        }
    }
}
