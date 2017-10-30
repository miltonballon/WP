using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Inventory
    {
        private Product product;
        private int stock;
        public Inventory()
        {
            new Product();
        }
        public Inventory(Product p, int s)
        {
            product = p;
            stock = s;
        }
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}
