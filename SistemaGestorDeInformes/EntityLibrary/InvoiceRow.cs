using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class InvoiceRow
    {
        private int id;
        private Product product;
        private double quantity;
        private double unitPrice;
        private double total;

        public InvoiceRow(int id, Product product, double quantity, double unitPrice, double total)
        {
            this.id = id;
            this.product = product;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.total = total;
        }

        public InvoiceRow(Product product, double quantity, double unitPrice, double total)
        {
            id = -1;
            this.product = product;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.total = total;
        }

        public InvoiceRow(Object[] data, String provider)
        {
            this.product = new Product();
            this.product.Name = (String)data[0];
            this.product.Unit = (String)data[1];
            this.product.Provider = provider;
            this.quantity = Double.Parse((String)data[2]);
            this.unitPrice = Double.Parse((String)data[3]);
            this.total = (double)data[4];
        }

        public void setAllAttributes(Object[] data, String provider)
        {
            this.product.Name = (String)data[0];
            this.product.Unit = (String)data[1];
            this.product.Provider = provider;
            this.quantity = Double.Parse((String)data[2]);
            this.unitPrice = Double.Parse((String)data[3]);
            this.total = (double)data[4];
        }

        public Product getProduct()
        {
            return product;
        }

        public void setProduct(Product product)
        {
            this.product = product;
        }

        public double getQuantity()
        {
            return quantity;
        }

        public void setQuantity(double quantity)
        {
            this.quantity = quantity;
        }

        public double getUnitPrice()
        {
            return unitPrice;
        }

        public void setUnitPrice(double unitPrice)
        {
            this.unitPrice = unitPrice;
        }

        public double getTotal()
        {
            return total;
        }

        public void setTotal(double total)
        {
            this.total = total;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String[] getAllAttributesAsText()
        {
            String[] output = new String[5];
            output[0] = product.Name;
            output[1] = product.Unit;
            output[2] = quantity+"";
            output[3] = unitPrice+"";
            output[4] = total+"";
            return output;
        }

        public override String ToString()
        {
            return product + " Cantidad: "+ quantity+" Precio Unitario: "+unitPrice+" Total: "+total;
        }
    }
}
