using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Trimester
    {
        private int id;
        private bool open;
        private String name;
        private DateTime initialDate;
        private DateTime endDate;

        public Trimester(string name)
        {
            this.name = name;
        }

        public Trimester(int id, string name)
        {
            this.name = name;
            this.id = id;
        }

        public Trimester(int id, string name, DateTime initialDate, DateTime endDate)
        {
            this.name = name;
            this.id = id;
            this.initialDate = initialDate;
            this.endDate = endDate;
        }

        public Trimester(string name, DateTime initialDate, DateTime endDate)
        {
            this.name = name;
            this.initialDate = initialDate;
            this.endDate = endDate;
        }

        public bool IsOpen()
        {
            return open;
        }

        public void SetOpen(bool open)
        {
            this.open = open;
        }

        public String GetName()
        {
            return name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public DateTime InitialDate
        { 
            get => initialDate;
            set => initialDate = value;
        }
        public DateTime EndDate
        {
            get => endDate;
            set => endDate = value;
        }

        public override string ToString()
        {
            String output=name+", \nDel: "+initialDate.ToShortDateString()+", \nAl: "+endDate.ToShortDateString();
            return output;
        }
    }
}
