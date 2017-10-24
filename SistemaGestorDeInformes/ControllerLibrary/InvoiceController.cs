using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaGestorDeInformes
{
    public class InvoiceController
    {
        private ProviderController providerController;
        private ProductController productController;
        private Connection c = new Connection();
        private TrimesterController trimesterController;
        private int ERROR,NOTRIMESTER;
        public InvoiceController()
        {
            c.connect();
            providerController = new ProviderController();
            productController = new ProductController();
            trimesterController = new TrimesterController();
            ERROR = -1;
            NOTRIMESTER=-2;
        }

        public int insertInvoice(Invoice invoice)
        {
            int output;
            Trimester trimester = trimesterController.getLastTrimester();
            if (trimester != null)
            {
                int nInvoice = invoice.getNInvoice(),
                nAutorization = invoice.getNAutorization(),
                idProvider = providerController.forceSearchProvider(invoice.getProvider()),
                idTrimester = trimester.getId();
                DateTime date = invoice.getDate();
                String query = "INSERT INTO Invoice(n_invoice, n_autorization, id_provider, nit, date, id_trimester) VALUES (";
                query += nInvoice + ", ";
                query += nAutorization + ", ";
                query += idProvider + ", ";
                query += invoice.getProvider().getNit() + ", '";
                query += date.ToString("dd/MM/yyyy") + "',";
                query += idTrimester + ")";
                try
                {
                    c.executeInsertion(query);
                    int id = c.FindAndGetID("select id FROM Invoice where n_invoice = " + nInvoice + " AND id_provider=" + idProvider);
                    output = registerInvoicesRows(invoice, id);
                }
                catch (Exception)
                {
                    output = ERROR;
                }
            }
            else
            {
                output = NOTRIMESTER;
            }
            return output;
        }

        public void updateInvoice(Invoice invoice,int id)
        {
            Provider provider = invoice.getProvider();
            int nInvoice = invoice.getNInvoice(),
                nAutorization = invoice.getNAutorization(), 
                idProvider = providerController.forceSearchProvider(provider), 
                nit=provider.getNit();
            String date = invoice.getDate().ToShortDateString();
            String query = "UPDATE Invoice SET n_invoice="+nInvoice+", n_autorization="+nAutorization+", id_provider="+idProvider+", nit="+nit+", date='"+date+"' WHERE id="+id;
            c.executeInsertion(query);
        }

        public int getInvoiceIdByObjectInvoice(Invoice invoice)
        {
            int id = 0;
            int nInvoice = invoice.getNInvoice(),
                providerId= providerController.forceSearchProvider(invoice.getProvider());
            String query = "SELECT id FROM Invoice WHERE n_invoice="+nInvoice+" AND id_provider="+providerId;
            id = c.FindAndGetID(query);
            c.dataClose();
            return id;
        }

        public int registerInvoicesRows(Invoice invoice,int invoiceId)
        {
            int counter = 0;
            foreach (InvoiceRow row in invoice.getInvoiceRows())
            {
                registerInvoiceRow(row,invoiceId);
                counter++;
            }
            return counter;
        }

        public void registerInvoiceRow(InvoiceRow row,int invoiceId)
        {
            String quantity = row.getQuantity() + ""
                , unitPrice= row.getUnitPrice() + ""
                , total=row.getTotal()+"";
            int idPpu = productController.insertProductAndGetId(row.getProduct());
            String queryInsertion = "INSERT INTO invoice_row (id_invoice, id_ppu, quantity, unit_price, total) VALUES(";
            queryInsertion += invoiceId + ", ";
            queryInsertion += idPpu + ", ";
            queryInsertion += "'"+quantity + "', ";
            queryInsertion += "'"+unitPrice + "', ";
            queryInsertion += "'"+total+"')" ;
            c.executeInsertion(queryInsertion);
        }

        public Invoice getInvoiceByNInvoiceAndProviderId(int nInvoice, int providerId)
        {
            Invoice invoice = null;
            string query = "SELECT * FROM Invoice WHERE n_invoice="+nInvoice+" AND id_provider="+providerId;
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                int invoiceId = Int32.Parse(data[0].ToString()),
                    nAut = Int32.Parse(data[2].ToString()),
                    provId = Int32.Parse(data[3].ToString());
                DateTime date = getDate(data[5].ToString());
                Provider provider = providerController.getProviderById(provId);
                invoice = new Invoice(provider, nInvoice, nAut, date);
                List<InvoiceRow> invoiceRows = getAllInvoicesRowByNInvoice(invoiceId);
                invoice.setInvoiceRows(invoiceRows);
            }
            c.dataClose();
            data.Close();
            return invoice;
        }

        public List<Invoice> getAllInvoices()
        {
            List<Invoice> output = new List<Invoice>();
            string query = "SELECT * FROM Invoice";
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                int invoiceId= Int32.Parse(data[0].ToString()),
                    nInvoice = Int32.Parse(data[1].ToString()),
                    nAut = Int32.Parse(data[2].ToString()),
                    provId = Int32.Parse(data[3].ToString());
                DateTime date = getDate(data[5].ToString());
                Provider provider = providerController.getProviderById(provId);
                Invoice invoice = new Invoice(provider, nInvoice, nAut, date);
                List<InvoiceRow> invoiceRows = getAllInvoicesRowByNInvoice(invoiceId);
                invoice.setInvoiceRows(invoiceRows);
                output.Add(invoice);
            }
            data.Close();
            c.dataClose();
            return output;
        }

        public List<InvoiceRow> getAllInvoicesRowByNInvoice(int idInvoice)
        {
            List<InvoiceRow> output = new List<InvoiceRow>();
            string query = "SELECT * FROM invoice_row WHERE id_invoice="+idInvoice;
            try
            {
                SQLiteDataReader data = c.query_show(query);
                while (data.Read())
                {
                    int ppuId = Int32.Parse(data[2].ToString());
                    double quantity = Double.Parse(data[3].ToString()),
                        unitPrice= Double.Parse(data[4].ToString()),
                        total= Double.Parse(data[5].ToString());
                    Product product = productController.getProductByPPUId(ppuId);
                    InvoiceRow invoiceRow = new InvoiceRow(product, quantity, unitPrice, total);
                    output.Add(invoiceRow);
                }
                data.Close();
            }
            catch (Exception)
            { }
            c.dataClose();
            return output;
        }

        private DateTime getDate(String dateString)
        {
            DateTime date;
            string[] dates = dateString.Split('/');
            int day = Int32.Parse(dates[0])
                , month= Int32.Parse(dates[1])
                , year = Int32.Parse(dates[2]);
            date = new DateTime(year, month, day);
            return date;
        }
    }
}
