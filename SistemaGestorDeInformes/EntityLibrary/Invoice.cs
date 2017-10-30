﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Invoice
    {
        private int id;
        private int nInvoice;
        private int nAutorization;
        private DateTime date;
        private List<InvoiceRow> InvoiceRows;
        private Provider provider;

        public Invoice(Provider provider, int nInvoice, int nAutorization, DateTime date)
        {
            this.provider = provider;
            this.nInvoice = nInvoice;
            this.nAutorization = nAutorization;
            this.date = date;
            InvoiceRows = new List<InvoiceRow>();
        }

        public Invoice(int id,Provider provider, int nInvoice, int nAutorization, DateTime date)
        {
            this.id = id;
            this.provider = provider;
            this.nInvoice = nInvoice;
            this.nAutorization = nAutorization;
            this.date = date;
            InvoiceRows = new List<InvoiceRow>();
        }

        public void setProvider(Provider provider)
        {
            this.provider = provider;
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

        public Provider getProvider()
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

        public void setInvoiceRows(List<InvoiceRow> invoiceRows)
        {
            InvoiceRows = invoiceRows;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
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
