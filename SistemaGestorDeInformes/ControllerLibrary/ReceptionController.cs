using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using EntityLibrary;

namespace ControllerLibrary
{
    public class ReceptionController
    {

        private Connection c = new Connection();
        private ProductController productController;
        private InventoryController inventoryController;
        public ReceptionController()
        {
            c.connect();
            productController = new ProductController();
            inventoryController = new InventoryController();
        }
        

        public void RegisterReception(Reception reception)
        {

            int idName = getIdName(reception.Product.Name);
            int idProvider = getIdProvider(reception.Product.Provider);
            int idUnit = getIdUnit(reception.Product.Unit);
            int notExist = -1;
            int resul = -1;
            string queryPPU = "SELECT id FROM Product_Provider_Unit where id_prod='" + idName + "' and id_prov='" + idProvider + "' and id_uni='" + idUnit + "'";
            SQLiteDataReader data = c.query_show(queryPPU);
            while (data.Read())
            {
                resul = Int32.Parse(data[0].ToString());
            }
            c.dataClose();
            data.Close();
            if (idName != notExist && idProvider != notExist && idUnit != notExist && resul != notExist)
            {
                InsertReception(resul, reception);
                inventoryController.InsertToInventory(resul, reception);
                MessageBox.Show("Registrado Correctamente");
            }
            else
            {
                MessageBox.Show("El producto no existe, registre el producto previamente");
            }
        }

        public List<Reception> getAllReceptions()
        {
            List<Reception> receptions = new List<Reception>();
            string query = "SELECT * FROM Reception";
            try
            {
                SQLiteDataReader data = c.query_show(query);
                while (data.Read())
                {
                    int ppuId = Int32.Parse(data[1].ToString()),
                        total = Int32.Parse(data[4].ToString());
                    String recDate = data[2].ToString(),
                           expDate = data[3].ToString();
                    Product product = productController.getProductByPPUId(ppuId);
                    Reception reception = new Reception(product, recDate, expDate, total);
                    receptions.Add(reception);
                }
            }
            catch (Exception)
            { }
            c.dataClose();
            return receptions;
        }
        public List<Reception> searchReception(string name)
        {
            List<Reception> reception = new List<Reception>();
            
            string query = "select name, Type, total  FROM Reception AS REC, Product AS PROD, Provider AS PRO, Unit AS Un, Product_Provider_Unit AS PPU WHERE PROD.id = PPU.Id_prod AND PRO.id= PPU.id_prov AND Un.id= PPU.id_uni AND REC.ppu_id=PPU.id AND UPPER (PROD.name)= UPPER(" + "'" + name + "')";
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Product prod = new Product();
                
                Reception p = new Reception();
                //MessageBox.Show("d"+data[0].ToString()+"B"+data[1].ToString()+"C"+Int32.Parse(data[2].ToString()));
                prod.Name = data[0].ToString();
                prod.Unit = data[1].ToString();
                p.Product = prod;

                
            }
            
            c.dataClose();
            data.Close();
            return reception;
        }

        public void updateReception(int idReception, Reception reception)
        {
            String expDate = reception.ExpirationDate;
            int total = reception.Total;
            String query = "UPDATE Reception SET total=" + total + ", expirationDate='" + expDate + "' WHERE id=" + idReception;
            c.executeInsertion(query);
        }

        public void ProductAutoComplete(TextBox Product)
        {
            string query = "SELECT name FROM Product";

            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Product.AutoCompleteCustomSource.Add(data["name"].ToString());

            }
            c.dataClose();
            data.Close();
        }

        public void ProviderAutoComplete(TextBox Provider)
        {
            string query = "SELECT Provider FROM Provider";

            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Provider.AutoCompleteCustomSource.Add(data["Provider"].ToString());
            }
            c.dataClose();
            data.Close();
        }

        public void UnitAutoComplete(TextBox Unit)
        {
            string query = "SELECT Type FROM Unit";

            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Unit.AutoCompleteCustomSource.Add(data["Type"].ToString());
            }
            c.dataClose();
            data.Close();
        }
        

        public void InsertReception(int id, Reception reception)
        {
            
            string query = "INSERT INTO Reception (ppu_id,receptionDate,expirationDate,total) values('" + id + "','" + reception.ExpirationDate + "','" + reception.ReceptionDate + "','" + reception.Total + "')";
            c.executeInsertion(query);
        }
        public int getIdName(string name)
        {
            string NameQuery = "select id FROM Product where name = " + "'" + name + "'";
            return c.FindAndGetID(NameQuery); 
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

        

        public Reception getReceptionById(int id)
        {
            Reception reception=null;
            String query = "SELECT * FROM Reception WHERE id="+id;
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                int ppuId = Int32.Parse(data[1].ToString()),
                    total = Int32.Parse(data[4].ToString());
                String recDate = data[2].ToString(),
                       expDate = data[3].ToString();
                Product product = productController.getProductByPPUId(ppuId);
                reception = new Reception(product, recDate, expDate, total);
            }
            c.dataClose();
            return reception;
        }

   
    }
}
