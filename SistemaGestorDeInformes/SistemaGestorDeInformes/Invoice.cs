using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class Invoice
    {
        private String provider;
        private int nit;
        private int nInvoice;
        private int nAutorization;
        private DateTime date;
        private List<InvoiceRow> InvoiceRows;

        public Invoice(string provider, int nit, int nInvoice, int nAutorization, DateTime date)
        {
            this.provider = provider;
            this.nit = nit;
            this.nInvoice = nInvoice;
            this.nAutorization = nAutorization;
            this.date = date;
            InvoiceRows = new List<InvoiceRow>();
        }

        public void setProvider(String provider)
        {
            this.provider = provider;
        }

        public void setNit(int nit_1)
        {
            nit = nit_1;
        }

        public void setNInvoice(int nInvoice_1)
        {
            nInvoice = nInvoice_1;
        }

        public void setNAutorization(int nAutorization_1)
        {
            nAutorization = nAutorization_1;
        }

        public void setDate(DateTime date_1)
        {
            date = date_1;
        }

        public int getNit()
        {
            return nit;
        }

        public string getProvider()
        {
            return provider;
        }

        public int getNInvoice()
        {
            return nInvoice;
        }

        public int getNAutorization()
        {
            return nAutorization;
        }

        public DateTime getDate()
        {
            return date;
        }

        public List<InvoiceRow> getInvoiceRows()
        {
            return InvoiceRows;
        }

        public void addInvoiceRow(InvoiceRow invoiceRow)
        {
            InvoiceRows.Add(invoiceRow);
        }

        public override String ToString()
        {
            String output= "provider: " + provider + "\nnit: " + nit + "\nN.Factura: " + nInvoice + "\nN.Autorizacion: "
                + nAutorization + "\n date: " + date.ToString();
            foreach (InvoiceRow row in InvoiceRows)
            {
                output += "\n"+row;
            }
            return output;
        }
    }
}
