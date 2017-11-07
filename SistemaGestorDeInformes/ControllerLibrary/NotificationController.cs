using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary
{
    class NotificationController
    {
        InventoryController inventoryController;
        ConfigurationController configurationController;

        public NotificationController()
        {
            inventoryController = new InventoryController();
            configurationController = new ConfigurationController();
        }

    }
}
