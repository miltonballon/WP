using System;
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
                idProveedor = buscarProveedor(factura.getProveedor()); ;
            DateTime fecha = factura.getFecha();
            String consulta = "INSERT INTO FACTURA(n_factura, n_autorizacion, id_proveedor, nit, fecha) VALUES (";
            consulta += nFactura+", ";
            consulta += nAutorizacion + ", ";
            consulta += idProveedor + ", ";
            consulta += nit + ", ";
            consulta += "#"+fecha.ToString("dd/MM/yyyy")+"#)";
            //MessageBox.Show(consulta);
            c.executeInsertion(consulta);
            MessageBox.Show(c.buscarYDevolverId("select nit FROM Factura where n_factura = " + nFactura)+""); 
        }

        public int buscarProveedor(String nombreProveedor)
        {
            String consulta = "select id FROM Proveedor where Proveedor = '" + nombreProveedor + "'";
            int id = c.buscarYDevolverId(consulta);
            return id;
        }

    }
}
