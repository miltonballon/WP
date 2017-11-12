using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Windows.Forms;
using EntityLibrary;
using System.Data;

namespace ControllerLibrary
{
    public class InvoiceController
    {
        private ProviderController providerController;
        private Connection c;
        private TrimesterController trimesterController;
        private InvoiceRowController invoiceRowController;
        private int ERROR,NOTRIMESTER;
        private SQLiteConnection connectionString;
        public InvoiceController()
        {
            c = new Connection();
            providerController = new ProviderController();
            invoiceRowController = new InvoiceRowController();
            trimesterController = new TrimesterController();
            c.connect();
            ERROR = -1;
            NOTRIMESTER=-2;
            connectionString = c.ConnectionString;
        }

        public int InsertInvoice(Invoice invoice)
        {
            int output;
            Trimester trimester = trimesterController.GetLastTrimester();
            if (trimester != null)
            {
                String nInvoice = invoice.GetNInvoice(),
                       nAutorization = invoice.GetNAutorization(),
                       date= invoice.GetDate().ToString("dd/MM/yyyy");
                int idProvider = providerController.ForceSearchProvider(invoice.GetProvider()),
                    idTrimester = trimester.GetId();
                String query = "INSERT INTO Invoice(n_invoice, n_autorization, id_provider, date, id_trimester) VALUES (@nInvoice, @nAuto, @IDProv, @date, @IDTrim)";

                SQLiteCommand command = new SQLiteCommand(query, connectionString);
                command.Parameters.Add("@nInvoice", DbType.String);
                command.Parameters.Add("@nAuto", DbType.String);
                command.Parameters.Add("@IDProv", DbType.Int32);
                command.Parameters.Add("@date", DbType.String);
                command.Parameters.Add("@IDTrim", DbType.Int32);
                command.Parameters["@nInvoice"].Value = nInvoice;
                command.Parameters["@nAuto"].Value = nAutorization;
                command.Parameters["@IDProv"].Value = idProvider;
                command.Parameters["@date"].Value = date;
                command.Parameters["@IDTrim"].Value = idTrimester;

                try
                {
                    c.executeInsertion(command);
                    int id = c.FindAndGetID("select id FROM Invoice where n_invoice = '" + nInvoice + "' AND id_provider=" + idProvider);
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
            String nInvoice = invoice.GetNInvoice(),
                nAutorization = invoice.GetNAutorization();
            int idProvider = providerController.ForceSearchProvider(provider);
            String date = invoice.GetDate().ToString("dd/MM/yyyy");
            String query = "UPDATE Invoice SET n_invoice = @nInvoice, n_autorization = @nAuto, id_provider = @IDProv, date = @date' WHERE id = @ID";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@nInvoice", DbType.String);
            command.Parameters.Add("@nAuto", DbType.String);
            command.Parameters.Add("@IDProv", DbType.Int32);
            command.Parameters.Add("@date", DbType.String);
            command.Parameters.Add("@ID", DbType.Int32);
            command.Parameters["@nInvoice"].Value = nInvoice;
            command.Parameters["@nAuto"].Value = nAutorization;
            command.Parameters["@IDProv"].Value = idProvider;
            command.Parameters["@date"].Value = date;
            command.Parameters["@ID"].Value = id;

            c.executeInsertion(command);
            invoiceRowController.UpdateAllRowsOrInsert(invoice.GetInvoiceRows(),GetInvoiceIdByObjectInvoice(invoice));
        }

        public int GetInvoiceIdByObjectInvoice(Invoice invoice)
        {
            int id = 0;
            String nInvoice = invoice.GetNInvoice();
            int providerId= providerController.ForceSearchProvider(invoice.GetProvider());
            String query = "SELECT id FROM Invoice WHERE n_invoice = @nInvoice AND id_provider = @IDProv";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@nInvoice", DbType.String);
            command.Parameters.Add("@IDProv", DbType.Int32);
            command.Parameters["@nInvoice"].Value = nInvoice;
            command.Parameters["@IDProv"].Value = providerId;

            id = c.FindAndGetID(command);
            c.dataClose();
            return id;
        }

        public Invoice GetInvoiceById(int id)
        {
            Invoice invoice = null;
            string query = "SELECT * FROM Invoice WHERE id = @ID";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@ID", DbType.String);
            command.Parameters["@ID"].Value = id;

            SQLiteDataReader data = c.query_show(command);
            while (data.Read())
            {
                String nAut = data[2].ToString(),
                    nInvoice = data[1].ToString();
                int invoiceId = Int32.Parse(data[0].ToString()),
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
            string query = "SELECT * FROM Invoice WHERE n_invoice = @nInvoice AND id_provider = @IDProv";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@nInvoice", DbType.String);
            command.Parameters.Add("@IDProv", DbType.Int32);
            command.Parameters["@nInvoice"].Value = nInvoice;
            command.Parameters["@IDProv"].Value = providerId;

            SQLiteDataReader data = c.query_show(command);
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
            string query = "SELECT * FROM Invoice WHERE id_trimester = @IDTrim";

            SQLiteCommand command = new SQLiteCommand(query, connectionString);
            command.Parameters.Add("@IDTrim", DbType.Int32);
            command.Parameters["@IDTrim"].Value = idTrimester;

            SQLiteDataReader data = c.query_show(command);
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
