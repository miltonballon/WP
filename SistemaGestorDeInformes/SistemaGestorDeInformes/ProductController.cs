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
            int affected = 0;
            Product p = new Product(product.Text,provider.Text,unit.Text);
            if (getIdName(p.Name) == -1) //si es -1 quiere decir que no existe y por tanto se crea
            {
                InsertProduct(p.Name);
                affected++;
            }
            if (getIdProvider(p.Provider) == -1)
            {
                InsertProvider(p.Provider);
                affected++;
            }
            if (getIdUnit(p.Unit) == -1)
            {
                InsertUnit(p.Unit);
                affected++;
            }  
            return affected;
        }

        public void addReferencesToTableProduct_Provider_Unit(TextBox product, TextBox provider, TextBox unit)
        {
            Product p = new Product(product.Text, provider.Text, unit.Text);
            InsertProduct_Provider_Unit(getIdName(p.Name),getIdProvider(p.Provider),getIdUnit(p.Unit));   
        }

        public void showProducts(DataGridView d)
        {
            List<Product> products = new List<Product>();
            string query = "select name, Provider, Type FROM Product AS PROD, Provider AS PRO, Unit AS Un, Product_Provider_Unit AS PPU WHERE PROD.id = PPU.Id_prod AND PRO.id= PPU.id_prov AND Un.id= PPU.id_uni";
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Product p = new Product(data[0].ToString(),data[1].ToString(),data[2].ToString());
                products.Add(p);
                d.DataSource = products;
            }
        }

        public List<Product> showAllProductsByProvider(String providersName)
        {
            List<Product> products = new List<Product>();
            string query = "select name, Provider, Type FROM Product AS PROD, Provider AS PRO, Unit AS Un, Product_Provider_Unit AS PPU WHERE PROD.id = PPU.Id_prod AND PRO.id= PPU.id_prov AND Un.id= PPU.id_uni";
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Product p = new Product(data[0].ToString(), data[1].ToString(), data[2].ToString());
                if (p.Provider.Equals(providersName))
                {
                    products.Add(p);
                }
            }
            return products;
        }

        public void searchProduct(DataGridView d,string name)
        {
            List<Product> products = new List<Product>();
            string query = "select name, Provider, Type FROM Product AS PROD, Provider AS PRO, Unit AS Un, Product_Provider_Unit AS PPU WHERE PROD.id = PPU.Id_prod AND PRO.id= PPU.id_prov AND Un.id= PPU.id_uni and UPPER (PROD.name)= UPPER(" + "'" + name + "')";
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Product p = new Product(data[0].ToString(), data[1].ToString(), data[2].ToString());
                products.Add(p);
                d.DataSource = products;
            }
        }
        

        public int getIdName(string name)
        {
            string NameQuery = "select id FROM Product where name = " + "'" + name + "'";
            return c.FindAndGetID(NameQuery); //-si retorna -1 quiere decir que esta vacio la consulta y no existe el elemento
        }
        public int getIdProvider(string provider)
        {
            string ProviderQuery = "select id FROM Provider where Provider = " + "'" + provider + "'";
            return c.FindAndGetID(ProviderQuery);
        }
        public int getIdUnit(string unit)
        {
            string UnitQuery = "select id FROM Unit where Type = " + "'" + unit + "'";
            return c.FindAndGetID(UnitQuery);
        }
        
        public void InsertProduct(string name)
        {
            string query = "insert into Product (name) values('" + name + "')";
            c.executeInsertion(query);
        }
        public void InsertProvider(string provider)
        {
            string query = "insert into Provider (Provider) values('" + provider + "')";
            c.executeInsertion(query);
        }
        public void InsertUnit(string unit)
        {
            string query = "insert into Unit (Type) values('" + unit + "')";
            c.executeInsertion(query);
        }
        public void InsertProduct_Provider_Unit(int IDProduct ,int IDProvider,int IDUnit)
        {
            string query = "insert into Product_Provider_Unit (Id_prod,id_prov,id_uni) values('" + IDProduct + "','" + IDProvider + "','" + IDUnit + "')";
            c.executeInsertion(query);
        }
        
    }
}