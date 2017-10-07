using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace SistemaGestorDeInformes
{
    class ProductController
    {
        public Connection c = new Connection();
        public ProductController()
        {
            c.connect();
        }

        public int insertProduct(TextBox product, TextBox provider, TextBox unit)
        {
            int afectadas = 0;
            Product p = new Product(product.Text,provider.Text,unit.Text);
            if (getIdName(p.Nombre) == -1) //si es -1 quiere decir que no existe y por tanto se crea
            {
                InsertProduct(p.Nombre);
                afectadas++;
            }
            if (getIdProvider(p.Proveedor) == -1)
            {
                InsertProvider(p.Proveedor);
                afectadas++;
            }
            if (getIdUnit(p.Unidad) == -1)
            {
                InsertUnit(p.Unidad);
                afectadas++;
            }  
            return afectadas;
        }

        public void addReferencesToTableProduct_Provider_Unit(TextBox product, TextBox provider, TextBox unit)
        {
            Product p = new Product(product.Text, provider.Text, unit.Text);
            InsertProduct_Provider_Unit(getIdName(p.Nombre),getIdProvider(p.Proveedor),getIdUnit(p.Unidad));   
        }

        public void showProducts(DataGridView d)
        {
            List<Product> products = new List<Product>();
            string query = "select nombre, Proveedor, Tipo FROM Producto AS PROD, Proveedor AS PRO, Unidad AS Un, Producto_Proveedor_Unidad AS PPU WHERE PROD.id = PPU.Id_prod AND PRO.id= PPU.id_prov AND Un.id= PPU.id_uni";
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Product p = new Product(data[0].ToString(),data[1].ToString(),data[2].ToString());
                products.Add(p);
                d.DataSource = products;
            }
        }


        public int getIdName(string name)
        {
            string NombreQuery = "select id FROM Producto where Nombre = " + "'" + name + "'";
            return c.FindAndGetID(NombreQuery); //-si retorna -1 quiere decir que esta vacio la consulta y no existe el elemento
        }
        public int getIdProvider(string provider)
        {
            string ProveedorQuery = "select id FROM Proveedor where Proveedor = " + "'" + provider + "'";
            return c.FindAndGetID(ProveedorQuery);
        }
        public int getIdUnit(string unit)
        {
            string UnidadQuery = "select id FROM Unidad where Tipo = " + "'" + unit + "'";
            return c.FindAndGetID(UnidadQuery);
        }
        
        public void InsertProduct(string name)
        {
            string query = "insert into Producto (nombre) values('" + name + "')";
            c.executeInsertion(query);
        }
        public void InsertProvider(string provider)
        {
            string query = "insert into Proveedor (Proveedor) values('" + provider + "')";
            c.executeInsertion(query);
        }
        public void InsertUnit(string unit)
        {
            string query = "insert into Unidad (Tipo) values('" + unit + "')";
            c.executeInsertion(query);
        }
        public void InsertProduct_Provider_Unit(int IDProduct ,int IDProvider,int IDUnit)
        {
            string query = "insert into Producto_Proveedor_Unidad (Id_prod,id_prov,id_uni) values('" + IDProduct + "','" + IDProvider + "','" + IDUnit + "')";
            c.executeInsertion(query);
        }
        
    }
}