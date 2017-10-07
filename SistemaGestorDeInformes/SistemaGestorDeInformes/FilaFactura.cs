using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class FilaFactura
    {
        private Product producto;
        private double cantidad;
        private double precioUnitario;
        private double total;

        public FilaFactura(Product producto, double cantidad, double precioUnitario, double total)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
            this.total = total;
        }

        public FilaFactura(Object[] datos,String proveedor)
        {
            this.producto = new Product();
            this.producto.Nombre = (String)datos[0];
            this.producto.Unidad = (String)datos[1];
            this.producto.Proveedor = proveedor;
            this.cantidad = Double.Parse((String)datos[2]);
            this.precioUnitario = Double.Parse((String)datos[3]);
            this.total = (double)datos[4];
        }

        public Product getProducto()
        {
            return producto;
        }

        public double getCantidad()
        {
            return cantidad;
        }

        public double getPrecioUnitario()
        {
            return precioUnitario;
        }

        public double getTotal()
        {
            return total;
        }

        public void setProducto(Product producto)
        {
            this.producto = producto;
        }

        public override String ToString()
        {
            return producto + " Cantidad: "+ cantidad+" Precio Unitario: "+precioUnitario+" Total: "+total;
        }

    }
}
