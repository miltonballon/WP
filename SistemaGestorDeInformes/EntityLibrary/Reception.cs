using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    public class Reception
    {
        private Product product;
        private string expirationDate;
        private string receptionDate;
        private int total;
        public Reception()
        {
        }

        public Reception(Product product, string expirationDate, string receptionDate, int total)
        {
            this.product = product;
            this.expirationDate = expirationDate;
            this.receptionDate = receptionDate;
            this.total = total;
        }

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        public string ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        public string ReceptionDate
        {
            get { return receptionDate; }
            set { receptionDate = value; }
        }
        public string Provider
        {
            get { return receptionDate; }
            set { receptionDate = value; }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        
        
        
    }
}
