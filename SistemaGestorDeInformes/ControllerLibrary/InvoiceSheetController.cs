using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Data.SQLite;
namespace ControllerLibrary
{
    public class InvoiceSheetController
    {
        private Connection c;
        private InvoiceSheetController invoiceSheetController;
        private InvoiceController invoiceController;
        private TrimesterController trimesterController;

        public static implicit operator InvoiceSheetController(QuotationSheetGenerator v)
        {
            throw new NotImplementedException();
        }
    }

    

    
}
