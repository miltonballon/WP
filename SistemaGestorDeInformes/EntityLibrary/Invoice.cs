using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Invoice
    {
        private int id;
        private String nInvoice;
        private String nAutorization;
        private DateTime date;
        private List<InvoiceRow> InvoiceRows;
        private Provider provider;
        private double total;

        public Invoice(Provider provider, String nInvoice, String nAutorization, DateTime date)
        {
            this.provider = provider;
            this.nInvoice = nInvoice;
            this.nAutorization = nAutorization;
            this.date = date;
            InvoiceRows = new List<InvoiceRow>();
        }

        public Invoice(int id,Provider provider, String nInvoice, String nAutorization, DateTime date)
        {
            this.id = id;
            this.provider = provider;
            this.nInvoice = nInvoice;
            this.nAutorization = nAutorization;
            this.date = date;
            InvoiceRows = new List<InvoiceRow>();
        }

        public void SetProvider(Provider provider)
        {
            this.provider = provider;
        }

        public void SetNInvoice(String nInvoice_1)
        {
            nInvoice = nInvoice_1;
        }

        public void SetNAutorization(String nAutorization_1)
        {
            nAutorization = nAutorization_1;
        }

        public void SetDate(DateTime date_1)
        {
            date = date_1;
        }

        public Provider GetProvider()
        {
            return provider;
        }

        public String GetNInvoice()
        {
            return nInvoice;
        }

        public String GetNAutorization()
        {
            return nAutorization;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public List<InvoiceRow> GetInvoiceRows()
        {
            return InvoiceRows;
        }

        public void AddInvoiceRow(InvoiceRow invoiceRow)
        {
            InvoiceRows.Add(invoiceRow);
        }

        public void SetInvoiceRows(List<InvoiceRow> invoiceRows)
        {
            InvoiceRows = invoiceRows;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetTotal()
        {
            double addition = 0;
            foreach (InvoiceRow row in InvoiceRows)
            {
                addition += row.GetTotal();
            }
            total = addition;
        }

        public double GetTotal()
        {
            SetTotal();
            return total;
        }

        public override String ToString()
        {
            String output= provider + "\nN.Factura: " + nInvoice + "\nN.Autorizacion: "
                + nAutorization + "\n Fecha: " + date.ToString();
            foreach (InvoiceRow row in InvoiceRows)
            {
                output += "\n"+row;
            }
            return output;
        }
    }
}
