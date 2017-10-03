using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class FilaFactura
    {
        private Producto producto;
        private double cantidad;
        private double precioUnitario;
        private double total;

        public FilaFactura(Producto producto, double cantidad, double precioUnitario, double total)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
            this.total = total;
        }

        public FilaFactura(Object[] datos,String proveedor)
        {
            this.producto = new Producto();
            this.producto.Nombre = (String)datos[0];
            this.producto.Unidad = (String)datos[1];
            this.producto.Proveedor = proveedor;
            this.cantidad = Double.Parse((String)datos[2]);
            this.precioUnitario = Double.Parse((String)datos[3]);
            this.total = (double)datos[4];
        }

        public Producto getProducto()
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

        public void setProducto(Producto producto)
        {
            this.producto = producto;
        }


    }
}
