using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Data.SQLite;
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

            string query = "INSERT INTO Inventory (ppu_id,stock) values('" + id + "','" + reception.Total + "')";
            productController.c.executeInsertion(query);
        }
       

        public void updateReception(int idInventory, int total)
        {
            String query = "UPDATE Inventory SET stock=" + total + ", WHERE id=" + idInventory;
            productController.c.executeInsertion(query);
        }


        public int addTotalToProduct(int idInventory, Inventory inventory, int value)
        {
            String expDate = inventory.ExpirationDate;
            int total = inventory.Stock;
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
        public int restTotalToProduct(int idInventory, Inventory inventory, int value)
        {
            String expDate = inventory.ExpirationDate;
            int total = inventory.Stock;
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
