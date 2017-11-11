using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Provider
    {
        private int id;
        private String name;
        private String nit;
        private String address;
        private List<Product> products;

        public Provider(int id,string name, String nit)
        {
            this.id = id;
            this.name = name;
            this.nit = nit;
            products = new List<Product>();
        }
        public Provider(int id, string name, String nit, String address)
        {
            this.id = id;
            this.name = name;
            this.nit = nit;
            this.address = address;
            products = new List<Product>();
        }

        public Provider(string name, String nit)
        {
            this.name = name;
            this.nit = nit;
            products = new List<Product>();
        }
        public Provider(string name, String nit,String address)
        {
            this.name = name;
            this.nit = nit;
            this.address = address;
            products = new List<Product>();
        }
        public String GetName()
        {
            return name;
        }

        public String GetNit()
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

        public void SetNit(String nit)
        {
            this.nit = nit;
        }
        public void SetProducts(List<Product> products)
        {
            this.products = products;
        }

        public int GetId()
        {
            return this.id;
        }

        public String GetAddress()
        {
            return address;
        }

        public void SetAddress(String address)
        {
            this.address = address;
        }

        public override string ToString()
        {
            return "Proveedor: "+name+"\nNIT: "+nit;
        }

        public override bool Equals(object obj)
        {
            Provider provider = (Provider)obj;
            return this.name.Equals(provider.GetName());
        }
    }
}
