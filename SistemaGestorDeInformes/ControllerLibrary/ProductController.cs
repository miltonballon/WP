﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using EntityLibrary;
namespace ControllerLibrary
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

        public void insertProduct(Product p)
        {
            if (getIdName(p) == -1) 
            {
                InsertProduct(p.Name, p.Clasification);
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

        public void updateProduct(Product product, int id)
        {   
            int idprod=getIdName(product);
            int idprov=getIdProvider(product.Provider);
            int idunit=getIdUnit(product.Unit);
            string queryInsertion = "UPDATE Product_Provider_Unit SET id_prod="+idprod+",id_prov="+idprov+",id_uni="+idunit+" WHERE id="+id;
            c.executeInsertion(queryInsertion);
            
        }
        public int insertProductAndGetId(Product product)
        {
            string nameQuery = "select id FROM Product where Name = " + "'" + product.Name.ToString() + "'";
            string providerQuery = "select id FROM Provider where name = '" + product.Provider.ToString() + "'";
            string unitQuery = "select id FROM Unit where Type = " + "'" + product.Unit.ToString() + "'";
            int idProd = c.FindAndGetID(nameQuery)
                , idProv = c.FindAndGetID(providerQuery)
                , idUni = c.FindAndGetID(unitQuery);
            int id= searchPPU(idProd, idProv, idUni);
            if (id == -1)
            {
                insertProduct(product);
                addReferencesToTableProduct_Provider_Unit(product);
                id = searchPPU(idProd, idProv, idUni);
            }
            return id;
        }

        public int searchProduct(Product product)
        {
            string nameQuery = "select id FROM Product where Name = " + "'" + product.Name + "'";
            string providerQuery = "select id FROM Provider where name ='" + product.Provider+ "'";
            string unitQuery = "select id FROM Unit where Type = " + "'" + product.Unit + "'";
            int idProd = getIdName(product)
                , idProv = c.FindAndGetID(providerQuery)
                , idUni = c.FindAndGetID(unitQuery);
            int id = searchPPU(idProd, idProv, idUni);
            if (id == -1)
            {
                id = searchPPU(idProd, idProv, idUni);
            }
            return id;
        }

        private int searchPPU(int idProd, int idProv, int idUni)
        {
            String query = "SELECT id FROM Product_Provider_Unit WHERE "
                + "id_product=" + idProd + " and id_provider=" + idProv + " and id_unit=" + idUni + "";
            return c.FindAndGetID(query);
        }

        public void addReferencesToTableProduct_Provider_Unit(Product p)
        {
            InsertProduct_Provider_Unit(getIdName(p.Name),getIdProvider(p.Provider),getIdUnit(p.Unit));   
        }
        
        
        public List<Product> showProducts()
        {
            List<Product> products = new List<Product>();
            string query = "select name, name, Type, clasification FROM Product AS PROD, Provider AS PRO, Unit AS Un, Product_Provider_Unit AS PPU WHERE PROD.id = PPU.Id_product AND PRO.id= PPU.id_provider AND Un.id= PPU.id_unit";
            SQLiteDataReader data = c.query_show(query);
            SQLiteDataReader data2 = c.query_show(query);
            while (data.Read())
            {
                
                Product p = new Product(data[0].ToString(), data[1].ToString(), data[2].ToString(),data[3].ToString());
                products.Add(p);
                
            }
            c.dataClose();
            data.Close();
            return products;
        }
        public List<Product> showAllProductsByProvider(String providersName)
        {
            List<Product> products = new List<Product>();
            string query = "select name, name, Type, clasification FROM Product AS PROD, Provider AS PRO, Unit AS Un, Product_Provider_Unit AS PPU WHERE PROD.id = PPU.Id_product AND PRO.id= PPU.id_provider AND Un.id= PPU.id_unit";
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Product p = new Product(data[0].ToString(), data[1].ToString(), data[2].ToString(),data[3].ToString());
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
            Provider provider = providerController.GetProviderById(idProv);
            String productsName = getProductsNameById(idProd),
                   unitsName = getUnitsNameById(idUni),
                   providersName = provider.GetName();
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

        public List<Product> searchProduct(string name)
        {
            List<Product> products = new List<Product>();
            string query = "select name, name, Type, clasification FROM Product AS PROD, Provider AS PRO, Unit AS Un, Product_Provider_Unit AS PPU WHERE PROD.id = PPU.Id_product AND PRO.id= PPU.id_provider AND Un.id= PPU.id_unit and UPPER (PROD.name)= UPPER(" + "'" + name + "')";
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Product p = new Product(data[0].ToString(), data[1].ToString(), data[2].ToString(),data[3].ToString());
                products.Add(p);
            }
           
            c.dataClose();
            data.Close();
            return products;
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
            return c.FindAndGetID(NameQuery);
        }
        public int getIdName(Product p)
        {
            string NameQuery = "select id FROM Product where name ='"+p.Name+"' AND clasification='" + p.Clasification + "'";
            return c.FindAndGetID(NameQuery);
        }
        public int getIdProvider(string provider)
        {
            string ProviderQuery = "select id FROM Provider where name = " + "'" + provider + "'";
            return c.FindAndGetID(ProviderQuery);
        }
        public int getIdUnit(string unit)
        {
            string UnitQuery = "select id FROM Unit where Type = " + "'" + unit + "'";
            return c.FindAndGetID(UnitQuery);
        }
        
        public void InsertProduct(string name, string clasification)
        {
            string query = "insert into Product (name,clasification) values('" + name + "','"+clasification+"')";
            c.executeInsertion(query);
        }
        public void InsertProvider(string provider)
        {
            string query = "insert into Provider (name) values('" + provider + "')";
            c.executeInsertion(query);
        }
        public void InsertUnit(string unit)
        {
            string query = "insert into Unit (Type) values('" + unit + "')";
            c.executeInsertion(query);
        }
        public void InsertProduct_Provider_Unit(int IDProduct ,int IDProvider,int IDUnit)
        {
            string query = "insert into Product_Provider_Unit (Id_product,id_provider,id_unit) values('" + IDProduct + "','" + IDProvider + "','" + IDUnit + "')";
            c.executeInsertion(query);
        }
        public void DeleteProduct_Provider_Unit(int IDProduct, int IDProvider, int IDUnit)
        {
            
            string query = "delete from Product_Provider_Unit where Id_product='" + IDProduct + "' and id_provider='" + IDProvider + "' and id_unit='" + IDUnit + "'";
           
            c.executeInsertion(query);
        }
       

        
    }
}