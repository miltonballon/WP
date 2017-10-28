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

        public bool isOpen()
        {
            return open;
        }

        public void setOpen(bool open)
        {
            this.open = open;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
    }
}
