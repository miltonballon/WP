using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
namespace SistemaGestorDeInformes
{
    public class ProductController
    {
        public Connection c = new Connection();
        private ProviderController providerController;
        
        public ProductController()
        {
            c.connect();
            providerController = new ProviderController();
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
        public void insertProduct(Product p)
        {
            if (getIdName(p.Name) == -1) //si es -1 quiere decir que no existe y por tanto se crea
            {
                InsertProduct(p.Name);
            }
            if (getIdProvider(p.Provider) == -1)
            {
                InsertProvider(p.Provider);
            
            }
            if (getIdUnit(p.Unit) == -1)
            {
                InsertUnit(p.Unit);
            }
        }

        public void addReferencesToTableProduct_Provider_Unit(Product p)
        {
            InsertProduct_Provider_Unit(getIdName(p.Name), getIdProvider(p.Provider), getIdUnit(p.Unit));
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
            c.dataClose();
            data.Close();
        }
        public List<Product> showProducts()
        {
            List<Product> products = new List<Product>();
            string query = "select name, Provider, Type FROM Product AS PROD, Provider AS PRO, Unit AS Un, Product_Provider_Unit AS PPU WHERE PROD.id = PPU.Id_prod AND PRO.id= PPU.id_prov AND Un.id= PPU.id_uni";
            SQLiteDataReader data = c.query_show(query);
            SQLiteDataReader data2 = c.query_show(query);
            while (data.Read())
            {
                Product p = new Product(data[0].ToString(), data[1].ToString(), data[2].ToString());
                products.Add(p);
                
            }
            c.dataClose();
            data.Close();
            return products;
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
            c.dataClose();
            data.Close();
            return products;
        }

        public Product getProductByPPUId(int ppuId)
        {
            int[] ids = getForeignIds(ppuId);
            Product product = getProductByIds(ids);
            return product;
        }

        private Product getProductByIds(int[] ids)
        {
            Product product=null;
            int idProd=ids[0], 
                idProv= ids[1], 
                idUni= ids[2];
            Provider provider = providerController.getProviderById(idProv);
            String productsName = getProductsNameById(idProd),
                   unitsName = getUnitsNameById(idUni),
                   providersName = provider.getName();
            product = new Product(productsName,providersName,unitsName);
            return product;
        }

        private int[] getForeignIds(int ppuId)
        {
            int[] ids = new int[3];
            string query = "SELECT * FROM Product_Provider_Unit WHERE id="+ppuId;
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                ids[0] = Int32.Parse(data[1].ToString());
                ids[1] = Int32.Parse(data[2].ToString());
                ids[2] = Int32.Parse(data[3].ToString());
            }
            return ids;
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
            c.dataClose();
            data.Close();
        }

        public String getProductsNameById(int id)
        {
            String prodsName = "";
            String query = "SELECT * FROM Product WHERE id="+id;
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                prodsName = data[1].ToString();
            }
            return prodsName;
        }

        public String getUnitsNameById(int id)
        {
            String unitsName = "";
            String query = "SELECT * FROM Unit WHERE id=" + id;
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                unitsName = data[1].ToString();
            }
            return unitsName;
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
        public void DeleteProduct_Provider_Unit(int IDProduct, int IDProvider, int IDUnit)
        {
            
            string query = "delete from Product_Provider_Unit where Id_prod='" + IDProduct + "' and id_prov='" + IDProvider + "' and id_uni='" + IDUnit + "'";
            //string query = "delete from Product_Provider_Unit where Id_prod='1' and id_prov='1' and id_uni='1'";
            c.executeInsertion(query);
        }
       

        
    }
}