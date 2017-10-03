﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class Factura
    {
        private String Proveedor;
        private int Nit;
        private int NFactura;
        private int NAutorizacion;
        private DateTime Fecha;
        private List<FilaFactura> FilaFacturas;

        public Factura(string proveedor, int nit, int nFactura, int nAutorizacion, DateTime fecha)
        {
            Proveedor = proveedor;
            Nit = nit;
            NFactura = nFactura;
            NAutorizacion = nAutorizacion;
            Fecha = fecha;
            FilaFacturas = new List<FilaFactura>();
        }

        public void setProveedor(String Proveedor_1)
        {
            Proveedor = Proveedor_1;
        }

        public void setNit(int Nit_1)
        {
            Nit = Nit_1;
        }

        public void setNFactura(int NFactura_1)
        {
            NFactura = NFactura_1;
        }

        public void setNAutorizacion(int NAutorizacion_1)
        {
            NAutorizacion = NAutorizacion_1;
        }

        public void setFecha(DateTime Fecha_1)
        {
            Fecha = Fecha_1;
        }

        public int getNit()
        {
            return Nit;
        }

        public string getProveedor()
        {
            return Proveedor;
        }

        public int getNFactura()
        {
            return NFactura;
        }

        public int getNAutorizacion()
        {
            return NAutorizacion;
        }

        public DateTime getFecha()
        {
            return Fecha;
        }

        public List<FilaFactura> getFilaFacturas()
        {
            return FilaFacturas;
        }

        public void agregarFilaFactura(FilaFactura FilaFactura)
        {
            FilaFacturas.Add(FilaFactura);
        }
    }
}
