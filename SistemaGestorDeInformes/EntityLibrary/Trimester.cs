using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    public class Trimester
    {
        private bool open;
        private String name;

        public Trimester(string name)
        {
            this.name = name;
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
    }
}
