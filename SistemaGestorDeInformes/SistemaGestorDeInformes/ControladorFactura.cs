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
                MessageBox.Show(c.buscarYDevolverId("select id_proveedor FROM Factura where n_factura = " + nFactura) + "");
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

        public void registrarProductosDeLaFactura()
        {

        }
    }
}
