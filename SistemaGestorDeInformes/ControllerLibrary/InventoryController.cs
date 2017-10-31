using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Data.SQLite;
using System.Windows.Forms;
namespace ControllerLibrary
{
    public class InventoryController
    {
        
        private ProductController productController;
        
        public InventoryController()
        {
            productController = new ProductController();
        }
        public void InsertToInventory(int id, Reception reception)
        {
            if (findId(id) == -1)
            {
                string query = "INSERT INTO Inventory (ppu_id,stock) values('" + id + "','" + reception.Total + "')";
                productController.c.executeInsertion(query);
            }
            else
            {
                int total = addTotalToProduct(findId(id), reception.Total);
                //MessageBox.Show("asd" + findId(id) + " "+total);
                updateReception(findId(id), total);
            }
            
        }
        public void ModifyInventory(int id, OutputReception reception)
        {
            
                int total = restTotalToProduct(findId(id), reception.Total);
                MessageBox.Show("asd" + findId(id) + " " + total);
                updateReception(findId(id), total);
         

        }
        public List<Inventory> getAllProducts()
        {
            List<Inventory> receptions = new List<Inventory>();
            string query = "SELECT * FROM Inventory";
            try
            {
                SQLiteDataReader data = productController.c.query_show(query);
                while (data.Read())
                {
                    int ppuId = Int32.Parse(data[1].ToString()),
                        total = Int32.Parse(data[2].ToString());
                   
                    Product product = productController.getProductByPPUId(ppuId);
                    Inventory reception = new Inventory();
                    reception.Product = product;
                    reception.Stock = total;
                    receptions.Add(reception);
                    //MessageBox.Show("" + product.Name + "" + reception.Stock);
                }
            }
            catch (Exception)
            { }
            productController.c.dataClose();
            return receptions;
        }
        public bool ifProductIsAvailable(OutputReception outputReception,int ppu_id)
        {
            if (restTotalToProduct(findId(ppu_id), outputReception.Total) >= 0)
            {
                return true;
            }
            else { return false; }
        }
        public int findId(int id)
        {

            string query = "SELECT id FROM Inventory WHERE ppu_id=" + id;
            return productController.c.FindAndGetID(query);
        }
       

        public void updateReception(int idInventory, int total)
        {
            String query = "UPDATE Inventory SET stock=" + total + " WHERE id=" + idInventory;
            productController.c.executeInsertion(query);
        }


        public int addTotalToProduct(int idInventory, int value)
        {
            String query = "SELECT SUM(stock+" + value + ")from Inventory WHERE id='" + idInventory + "'";
            SQLiteDataReader data = productController.c.query_show(query);
            int resul = 0;
            while (data.Read())
            {
                resul = Int32.Parse(data[0].ToString());
            }
            productController.c.dataClose();
            data.Close();
            return resul;
        }
        public int restTotalToProduct(int idInventory, int value)
        {
            String query = "SELECT SUM(stock-" + value + ")from Inventory WHERE id='" + idInventory + "'";
            SQLiteDataReader data = productController.c.query_show(query);
            int resul = 0;
            while (data.Read())
            {
                resul = Int32.Parse(data[0].ToString());
            }
            productController.c.dataClose();
            data.Close();
            return resul;
        }
        
    }
}
