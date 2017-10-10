using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class Product
    {
        private string name;
        private string unit;
        private string provider;

        /* public void setNombre(string n) { nombre = n; }
         public void setUnidad(string u) { unidad = u; }
         public void setProveedor(string p) { proveedor = p; }
         public string getNombre() { return nombre;}
         public string getUnidad() { return unidad; }
         public string getProveedor() { return proveedor; }*/
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public override String ToString()
        {
            return "Nombre: "+name+" Unidad: "+unit+" Proveedor: "+provider;
        }
        public Product()
        {
            

        }
        public Product(string prod,string prov,string uni)
        {
            name = prod;
            provider = prov;
            unit = uni;

        }
    }

}
