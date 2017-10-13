﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeInformes
{
    public partial class ShowBills : Form
    {
        private InvoiceController invoiceController;
        public ShowBills()
        {
            InitializeComponent();
            invoiceController = new InvoiceController();
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipal principal = new InterfazPrincipal();
            principal.Show();
            this.Hide();
        }

         private void MainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipal MainForm = new InterfazPrincipal();
            MainForm.Show();
            this.Hide();
        }

        private void RegisterInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazRegistrarFactura RegisterInvoiceForm = new InterfazRegistrarFactura();
            RegisterInvoiceForm.Show();
            this.Hide();
        }

        private void registrarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazRegistrarFactura intRegFac = new InterfazRegistrarFactura();
            this.Hide();
            intRegFac.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct intRegisterProduct = new RegisterProduct();
            intRegisterProduct.Show();
            this.Hide();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts ShowProducts1 = new ShowProducts();
            this.Hide();
            ShowProducts1.Show();
        }

        private void buttonAtrás_Click(object sender, EventArgs e)
        {
            InterfazPrincipal principal = new InterfazPrincipal();//para volver atras
            this.Hide();
            principal.Show();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfiguration ReportConfiguration1 = new ReportConfiguration();
            this.Hide();
            ReportConfiguration1.Show();
        }

        private void abrirTrimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenQuarter OpenQuarter1 = new OpenQuarter();
            this.Hide();
            OpenQuarter1.Show();
        }

        public void onlyReadRestrictionDataGrid()
        {

            dataGridView1.Columns["NFactura"].ReadOnly = true;
            dataGridView1.Columns["Nautorizacion"].ReadOnly = true;
            dataGridView1.Columns["Nit"].ReadOnly = true;
            dataGridView1.Columns["Fecha"].ReadOnly = true;
            dataGridView1.Columns["Productos"].ReadOnly = true;
            dataGridView1.Columns["Proveedor"].ReadOnly = true;
        }

        private void ShowBills_Load(object sender, EventArgs e)
        {
            List<Invoice>invoices=invoiceController.getAllInvoices();
            dataGridView1.DataSource = invoices;

            onlyReadRestrictionDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}
