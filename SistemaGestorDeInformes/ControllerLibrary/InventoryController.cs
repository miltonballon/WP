using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
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
    }
}
