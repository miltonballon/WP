﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class Producto
    {
        private string nombre;
        private string unidad;
        private string proveedor;

        /* public void setNombre(string n) { nombre = n; }
         public void setUnidad(string u) { unidad = u; }
         public void setProveedor(string p) { proveedor = p; }
         public string getNombre() { return nombre;}
         public string getUnidad() { return unidad; }
         public string getProveedor() { return proveedor; }*/
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        public string Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
    }

}
