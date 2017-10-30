using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Data.SQLite;

namespace ControllerLibrary
{
    class InvoiceRowController
    {
        private ProviderController providerController;
        private ProductController productController;
        private Connection c;
        public InvoiceRowController()
        {
            c = new Connection();
            c.connect();
            providerController = new ProviderController();
            productController = new ProductController();
        }

        public int registerInvoicesRows(Invoice invoice, int invoiceId)
        {
            int counter = 0;
            foreach (InvoiceRow row in invoice.getInvoiceRows())
            {
                registerInvoiceRow(row, invoiceId);
                counter++;
            }
            return counter;
        }

        public void registerInvoiceRow(InvoiceRow row, int invoiceId)
        {
            String quantity = row.getQuantity() + ""
                , unitPrice = row.getUnitPrice() + ""
                , total = row.getTotal() + "";
            int idPpu = productController.insertProductAndGetId(row.getProduct());
            String queryInsertion = "INSERT INTO invoice_row (id_invoice, id_ppu, quantity, unit_price, total) VALUES(";
            queryInsertion += invoiceId + ", ";
            queryInsertion += idPpu + ", ";
            queryInsertion += "'" + quantity + "', ";
            queryInsertion += "'" + unitPrice + "', ";
            queryInsertion += "'" + total + "')";
            c.executeInsertion(queryInsertion);
        }

        public List<InvoiceRow> getAllInvoicesRowByNInvoice(int idInvoice)
        {
            List<InvoiceRow> output = new List<InvoiceRow>();
            string query = "SELECT * FROM invoice_row WHERE id_invoice=" + idInvoice;
            try
            {
                SQLiteDataReader data = c.query_show(query);
                while (data.Read())
                {
                    int ppuId = Int32.Parse(data[2].ToString()),
                        id= Int32.Parse(data[0].ToString());
                    double quantity = Double.Parse(data[3].ToString()),
                        unitPrice = Double.Parse(data[4].ToString()),
                        total = Double.Parse(data[5].ToString());
                    Product product = productController.getProductByPPUId(ppuId);
                    InvoiceRow invoiceRow = new InvoiceRow(id, product, quantity, unitPrice, total);
                    output.Add(invoiceRow);
                }
                data.Close();
            }
            catch (Exception)
            { }
            c.dataClose();
            return output;
        }
    }
}
