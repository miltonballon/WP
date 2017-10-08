using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class Provider
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

        public String getName()
        {
            return name;
        }

        public int getNit()
        {
            return nit;
        }

        public List<Product> getProducts()
        {
            return products;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setNit(int nit)
        {
            this.nit = nit;
        }
        public void setProducts(List<Product> products)
        {
            this.products = products;
        }

        public override string ToString()
        {
            return "Proveedor: "+name+"\nNIT: "+nit;
        }
    }
}
