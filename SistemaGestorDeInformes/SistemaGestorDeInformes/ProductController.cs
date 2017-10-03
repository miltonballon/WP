using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeInformes
{
    class ProductController
    {
        public Connection c = new Connection();
        public ProductController()
        {
            c.connect();
        }


        public void insertar(TextBox nombre, TextBox proveedor, TextBox unidad)
        {
            Producto p = new Producto();
            p.Nombre = nombre.Text;
            p.Proveedor = proveedor.Text;
            p.Unidad = unidad.Text;
            string query;
            string NombreQuery = "select id FROM Producto where Nombre = " + "'" + p.Nombre.ToString() + "'";
            string ProveedorQuery = "select id FROM Proveedor where Proveedor = " + "'" + p.Proveedor.ToString() + "'";
            string UnidadQuery = "select id FROM Unidad where Tipo = " + "'" + p.Unidad.ToString() + "'";


            int varNombre = c.buscarYDevolverId(NombreQuery); //-si retorna -1 quiere decir que esta vacio la consulta y no existe el elemento
            int varProveedor = c.buscarYDevolverId(ProveedorQuery);
            int varUnidad = c.buscarYDevolverId(UnidadQuery);
            if (varNombre == -1)
            {
                query = "insert into Producto (nombre) values('" + p.Nombre + "')";
                c.executeInsertion(query);
            }
            if (varProveedor == -1)
            {
                query = "insert into Proveedor (Proveedor) values('" + p.Proveedor + "')";
                c.executeInsertion(query);
            }
            if (varUnidad == -1)
            {
                query = "insert into Unidad (Tipo) values('" + p.Unidad + "')";
                c.executeInsertion(query);
            }
            c.connectionClose();
        }
        public void agregarIndices(TextBox nombre, TextBox proveedor, TextBox unidad)
        {
            c.connectionOpen();
            Producto p = new Producto();
            p.Nombre = nombre.Text;
            p.Proveedor = proveedor.Text;
            p.Unidad = unidad.Text;
            string query;
            string NombreQuery = "select id FROM Producto where Nombre = " + "'" + p.Nombre.ToString() + "'";
            string ProveedorQuery = "select id FROM Proveedor where Proveedor = " + "'" + p.Proveedor.ToString() + "'";
            string UnidadQuery = "select id FROM Unidad where Tipo = " + "'" + p.Unidad.ToString() + "'";
            //asignacion a la tabla  principal

            int varNombre = c.buscarYDevolverId(NombreQuery);
            int varProveedor = c.buscarYDevolverId(ProveedorQuery);
            int varUnidad = c.buscarYDevolverId(UnidadQuery);
            MessageBox.Show("N" + varNombre + "P" + varProveedor + "U" + varUnidad);
            query = "insert into Producto_Proveedor_Unidad (Id_prod,id_prov,id_uni) values('" + varNombre + "','" + varProveedor + "','" + varUnidad + "')";
            c.executeInsertion(query);
        }


        public void mostrarProducto(DataGridView d)
        {
            string query = "select DISTINCT nombre, Proveedor, Tipo FROM Producto AS PROD, Proveedor AS PRO, Unidad AS Un, Producto_Proveedor_Unidad AS PPU WHERE PROD.id = PPU.Id_prod AND PRO.id= PPU.Id_prov AND Un.id=PPU.id_uni";
            List<Producto> products = new List<Producto>();
            c.executeQuery(query);
            using (var reader = c.getCommmand().ExecuteReader())
            {
                while (reader.Read())
                {
                    Producto p = new Producto();
                    p.Nombre = reader.GetString(0).ToString();
                    p.Proveedor = reader.GetString(1).ToString();
                    p.Unidad = reader.GetString(2).ToString();
                    products.Add(p);
                    d.DataSource = products;
                }
            }
        }
    }
}