using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class Reception
    {
        private Product product;
        private string expirationDate;
        private string receptionDate;
        private int total;
        public Reception()
        {



        }
        public Product Product
        {
            get { return Product; }
            set { Product = value; }
        }
        public string ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }
        public string Provider
        {
            get { return receptionDate; }
            set { receptionDate = value; }
        }
        public int Unit
        {
            get { return total; }
            set { total = value; }
        }

        
        
        
    }
}
