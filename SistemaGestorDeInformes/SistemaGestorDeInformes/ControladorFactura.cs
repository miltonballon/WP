﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeInformes
{
    class ControladorFactura
    {
        public Connection c = new Connection();
        public ControladorFactura()
        {
            c.connect();
        }

        public void insertarFactura(Factura factura)
        {
            int nFactura = factura.getNFactura(),
                nAutorizacion = factura.getNAutorizacion(),
                nit = factura.getNit(),
                idProveedor = buscarProveedor(factura.getProveedor());
            DateTime fecha = factura.getFecha();
            String consulta = "INSERT INTO FACTURA(n_factura, n_autorizacion, id_proveedor, nit, fecha) VALUES (";
            consulta += nFactura+", ";
            consulta += nAutorizacion + ", ";
            consulta += idProveedor + ", ";
            consulta += nit + ", ";
            consulta += "#"+fecha.ToString("dd/MM/yyyy")+"#)";
            //MessageBox.Show(consulta);
            try
            {
                
                c.executeInsertion(consulta);
                //MessageBox.Show(c.buscarYDevolverId("select id_proveedor FROM Factura where n_factura = " + nFactura) + "");
                MessageBox.Show("Informacion Basica de la factura agregado","INFORME");
                registrarFilasDeLaFactura(factura);
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("El 'N. Factura' introducido ya existe.\nPor favor revise los datos introducidos.", "Error");
            }
        }

        public int buscarProveedor(String nombreProveedor)//refactorizar
        {
            String consulta = "select id FROM Proveedor where Proveedor = '" + nombreProveedor + "'";
            int id = c.buscarYDevolverId(consulta);

    
            if (id < 0)
            {
                consulta = "insert into Proveedor (Proveedor) values('" + nombreProveedor + "')";
                c.executeInsertion(consulta);
                consulta = "select id FROM Proveedor where Proveedor = '" + nombreProveedor + "'";
                id = c.buscarYDevolverId(consulta);
                MessageBox.Show("Nuevo proveedor registrado en el programa: " + nombreProveedor, "Nuevo Proveedor");
            }
            return id;
        }

        public void registrarFilasDeLaFactura(Factura factura)
        {
            int contador = 0;
            foreach (FilaFactura fila in factura.getFilaFacturas())
            {
                registrarFilaFactura(fila,factura.getNFactura());
                contador++;
            }
            MessageBox.Show(contador+" filas de la factura insertadas","INFORME");
        }

        public void registrarFilaFactura(FilaFactura fila,int nFact)//refactorizar
        {
            String cantidad = fila.getCantidad() + ""
                , precioUni= fila.getPrecioUnitario() + ""
                , total=fila.getTotal()+"";
            Producto aux = fila.getProducto();
            TextBox nombre = new TextBox();
            nombre.Text =aux.Nombre;
            TextBox proveedor = new TextBox();
            proveedor.Text = aux.Proveedor;
            TextBox unidad = new TextBox();
            unidad.Text = aux.Unidad;
            ProductController pC = new ProductController();
            int afectadas=pC.insertar(nombre,proveedor,unidad);
            if (afectadas > 0)
            {
                pC.agregarIndices(nombre,proveedor,unidad);
            }
            string value = "holaaa";
            string NombreQuery = "select id FROM Producto where Nombre = " + "'" + aux.Nombre.ToString() + "'";
            string ProveedorQuery = "select id FROM Proveedor where Proveedor = " + "'" + aux.Proveedor.ToString() + "'";
            string UnidadQuery = "select id FROM Unidad where Tipo = " + "'" + aux.Unidad.ToString() + "'";
            int idProd=c.buscarYDevolverId(NombreQuery)
                , idProv= c.buscarYDevolverId(ProveedorQuery)
                , idUni= c.buscarYDevolverId(UnidadQuery);
            String queryInsercion = "INSERT INTO Fila_Factura (n_factura, id_prod, id_prov, id_uni, cantidad, precio_uni, total) VALUES(";
            queryInsercion += nFact + ", ";
            queryInsercion += idProd + ", ";
            queryInsercion += idProv + ", ";
            queryInsercion += idUni + ", ";
            queryInsercion += "'"+cantidad + "', ";
            queryInsercion += "'"+precioUni + "', ";
            queryInsercion += "'"+total+"')" ;
            c.executeInsertion(queryInsercion);
        }
    }
}
