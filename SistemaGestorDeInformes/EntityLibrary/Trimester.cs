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

        public Trimester(string name)
        {
            this.name = name;
        }

        public Trimester(int id, string name)
        {
            this.name = name;
            this.id = id;
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
    }
}
