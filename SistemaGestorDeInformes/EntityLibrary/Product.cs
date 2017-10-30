using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Product
    {
        private string name;
        private string unit;
        private string provider;
        private string clasification;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public string Clasification
        {
            get { return clasification; }
            set { clasification = value; }
        }
        public override String ToString()
        {
            return "Nombre: "+name+" Unidad: "+unit;
        }
        public Product()
        {
            

        }
        public Product(string prod,string prov,string uni,string cla)
        {
            name = prod;
            provider = prov;
            unit = uni;
            clasification = cla;

        }

    }

}
