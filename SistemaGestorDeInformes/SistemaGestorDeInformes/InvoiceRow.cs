using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class InvoiceRow
    {
        private Product product;
        private double quantity;
        private double unitPrice;
        private double total;

        public InvoiceRow(Product product, double quantity, double unitPrice, double total)
        {
            this.product = product;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.total = total;
        }

        public InvoiceRow(Object[] datos,String provider)
        {
            this.product = new Product();
            this.product.Name = (String)datos[0];
            this.product.Unit = (String)datos[1];
            this.product.Provider = provider;
            this.quantity = Double.Parse((String)datos[2]);
            this.unitPrice = Double.Parse((String)datos[3]);
            this.total = (double)datos[4];
        }

        public Product getProduct()
        {
            return product;
        }

        public double getQuantity()
        {
            return quantity;
        }

        public double getUnitPrice()
        {
            return unitPrice;
        }

        public double getTotal()
        {
            return total;
        }

        public void setProduct(Product product)
        {
            this.product = product;
        }

        public override String ToString()
        {
            return product + " Cantidad: "+ quantity+" Precio Unitario: "+unitPrice+" Total: "+total;
        }

    }
}
