using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class Product
    {
        private string name;
        private string unit;
        private string provider;
        
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

        public override String ToString()
        {
            return "Nombre: "+name+" Unidad: "+unit;
        }
        public Product()
        {
            

        }
        public Product(string prod,string prov,string uni)
        {
            name = prod;
            provider = prov;
            unit = uni;

        }

    }

}
