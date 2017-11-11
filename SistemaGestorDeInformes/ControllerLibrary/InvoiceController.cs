using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Windows.Forms;
using EntityLibrary;

namespace ControllerLibrary
{
    public class InvoiceController
    {
        private ProviderController providerController;
        private Connection c;
        private TrimesterController trimesterController;
        private InvoiceRowController invoiceRowController;
        private int ERROR,NOTRIMESTER;
        public InvoiceController()
        {
            c = new Connection();
            providerController = new ProviderController();
            invoiceRowController = new InvoiceRowController();
            trimesterController = new TrimesterController();
            c.connect();
            ERROR = -1;
            NOTRIMESTER=-2;
        }

        public int InsertInvoice(Invoice invoice)
        {
            int output;
            Trimester trimester = trimesterController.GetLastTrimester();
            if (trimester != null)
            {
                int nInvoice = invoice.GetNInvoice(),
                nAutorization = invoice.GetNAutorization(),
                idProvider = providerController.ForceSearchProvider(invoice.GetProvider()),
                idTrimester = trimester.GetId();
                DateTime date = invoice.GetDate();
                String query = "INSERT INTO Invoice(n_invoice, n_autorization, id_provider, date, id_trimester) VALUES (";
                query += nInvoice + ", ";
                query += nAutorization + ", ";
                query += idProvider + ", ";
                query += date.ToString("dd/MM/yyyy") + "',";
                query += idTrimester + ")";
                try
                {
                    c.executeInsertion(query);
                    int id = c.FindAndGetID("select id FROM Invoice where n_invoice = " + nInvoice + " AND id_provider=" + idProvider);
                    output = invoiceRowController.RegisterInvoicesRows(invoice, id);
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

        public void UpdateInvoice(Invoice invoice,int id)
        {
            Provider provider = invoice.GetProvider();
            int nInvoice = invoice.GetNInvoice(),
                nAutorization = invoice.GetNAutorization(),
                idProvider = providerController.ForceSearchProvider(provider);
            String date = invoice.GetDate().ToShortDateString();
            String query = "UPDATE Invoice SET n_invoice="+nInvoice+", n_autorization="+nAutorization+", id_provider="+idProvider+", date='"+date+"' WHERE id="+id;
            c.executeInsertion(query);
            invoiceRowController.UpdateAllRowsOrInsert(invoice.GetInvoiceRows(),GetInvoiceIdByObjectInvoice(invoice));
        }

        public int GetInvoiceIdByObjectInvoice(Invoice invoice)
        {
            int id = 0;
            int nInvoice = invoice.GetNInvoice(),
                providerId= providerController.ForceSearchProvider(invoice.GetProvider());
            String query = "SELECT id FROM Invoice WHERE n_invoice="+nInvoice+" AND id_provider="+providerId;
            id = c.FindAndGetID(query);
            c.dataClose();
            return id;
        }

        public Invoice GetInvoiceById(int id)
        {
            Invoice invoice = null;
            string query = "SELECT * FROM Invoice WHERE id=" + id;
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                int invoiceId = Int32.Parse(data[0].ToString()),
                    nInvoice= Int32.Parse(data[1].ToString()),
                    nAut = Int32.Parse(data[2].ToString()),
                    provId = Int32.Parse(data[3].ToString());
                DateTime date = Util.GetDate(data[5].ToString());
                Provider provider = providerController.GetProviderById(provId);
                invoice = new Invoice(provider, nInvoice, nAut, date);
                List<InvoiceRow> invoiceRows = invoiceRowController.GetAllInvoicesRowByNInvoice(invoiceId);
                invoice.SetInvoiceRows(invoiceRows);
            }
            c.dataClose();
            data.Close();
            return invoice;
        }

        public Invoice GetInvoiceByNInvoiceAndProviderId(int nInvoice, int providerId)
        {
            Invoice invoice = null;
            string query = "SELECT * FROM Invoice WHERE n_invoice="+nInvoice+" AND id_provider="+providerId;
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                int invoiceId = Int32.Parse(data[0].ToString());
                invoice = GetInvoiceById(invoiceId);
            }
            c.dataClose();
            data.Close();
            return invoice;
        }

        public List<Invoice> GetAllInvoices()
        {
            List<Invoice> output = new List<Invoice>();
            string query = "SELECT * FROM Invoice";
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                int invoiceId = Int32.Parse(data[0].ToString());
                Invoice invoice = GetInvoiceById(invoiceId);
                output.Add(invoice);
            }
            data.Close();
            c.dataClose();
            return output;
        }

        public List<Invoice> GetAllInvoicesByTrimester(Trimester trimester)
        {
            List<Invoice> output = new List<Invoice>();
            int idTrimester = trimester.GetId();
            string query = "SELECT * FROM Invoice WHERE id_trimester="+idTrimester;
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                int invoiceId = Int32.Parse(data[0].ToString());
                Invoice invoice = GetInvoiceById(invoiceId);
                output.Add(invoice);
            }
            data.Close();
            c.dataClose();
            return output;
        }
    }
}
