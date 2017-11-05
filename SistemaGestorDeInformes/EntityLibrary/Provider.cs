using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Provider
    {
        private String name;
        private int nit;
        private List<Product> products;

        public Provider(string name, int nit)
        {
            this.name = name;
            this.nit = nit;
            products = new List<Product>();
        }

        public String GetName()
        {
            return name;
        }

        public int GetNit()
        {
            return nit;
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public void SetNit(int nit)
        {
            this.nit = nit;
        }
        public void SetProducts(List<Product> products)
        {
            this.products = products;
        }

        public override string ToString()
        {
            return "Proveedor: "+name+"\nNIT: "+nit;
        }
    }
}
