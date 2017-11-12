using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
using System.Data.SQLite;
using System.Data;

namespace ControllerLibrary
{
    class InvoiceRowController
    {
        private ProviderController providerController;
        private ProductController productController;
        private Connection c;
        private SQLiteConnection connectionString;
        public InvoiceRowController()
        {
            c = new Connection();
            c.connect();
            providerController = new ProviderController();
            productController = new ProductController();
            connectionString = c.ConnectionString;
        }

        public int RegisterInvoicesRows(Invoice invoice, int invoiceId)
        {
            int counter = 0;
            foreach (InvoiceRow row in invoice.GetInvoiceRows())
            {
                RegisterInvoiceRow(row, invoiceId);
                counter++;
            }
            return counter;
        }

        public void RegisterInvoiceRow(InvoiceRow row, int invoiceId)
        {
            String quantity = row.GetQuantity() + ""
                , unitPrice = row.GetUnitPrice() + ""
                , total = row.GetTotal() + "";
            int idPpu = productController.insertProductAndGetId(row.GetProduct());
            String query = "INSERT INTO invoice_row (id_invoice, id_ppu, quantity, unit_price, total) VALUES(@IDInvoice, @IDPpu, @quantity, @unit_price, @total)";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@IDInvoice", DbType.Int32);
            command.Parameters.Add("@IDPpu", DbType.Int32);
            command.Parameters.Add("@quantity", DbType.String);
            command.Parameters.Add("@unit_price", DbType.String);
            command.Parameters.Add("@total", DbType.String);
            command.Parameters["@IDInvoice"].Value = invoiceId;
            command.Parameters["@IDPpu"].Value = idPpu;
            command.Parameters["@quantity"].Value = quantity;
            command.Parameters["@unit_price"].Value = unitPrice;
            command.Parameters["@total"].Value = total;

            c.executeInsertion(command);
        }

        public List<InvoiceRow> GetAllInvoicesRowByNInvoice(int idInvoice)
        {
            List<InvoiceRow> output = new List<InvoiceRow>();
            string query = "SELECT * FROM invoice_row WHERE id_invoice = @IDInvoice";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@IDInvoice", DbType.Int32);
            command.Parameters["@IDInvoice"].Value = idInvoice;

            try
            {
                SQLiteDataReader data = c.query_show(command);
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

        public void UpdateAllRowsOrInsert(List<InvoiceRow> rows, int invoiceId)
        {
            foreach (InvoiceRow row in rows)
            {
                if (row.GetId() > 0)
                {
                    UpdateInvoiceRow(row);
                }
                else
                {
                    RegisterInvoiceRow(row,invoiceId);
                }
            }
        }

        public void UpdateInvoiceRow(InvoiceRow row)
        {
            String quantity = row.GetQuantity() + ""
                , unitPrice = row.GetUnitPrice() + ""
                , total = row.GetTotal() + "";
            int idPpu = productController.insertProductAndGetId(row.GetProduct()),
                id=row.GetId();
            String query = "UPDATE invoice_row SET id_ppu = @IDPpu, quantity = @quantity, unit_price = @unit_price, total = @total WHERE id = @ID";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@ID", DbType.Int32);
            command.Parameters.Add("@IDPpu", DbType.Int32);
            command.Parameters.Add("@quantity", DbType.String);
            command.Parameters.Add("@unit_price", DbType.String);
            command.Parameters.Add("@total", DbType.String);
            command.Parameters["@ID"].Value = id;
            command.Parameters["@IDPpu"].Value = idPpu;
            command.Parameters["@quantity"].Value = quantity;
            command.Parameters["@unit_price"].Value = unitPrice;
            command.Parameters["@total"].Value = total;

            c.executeInsertion(command);
        }
    }
}
