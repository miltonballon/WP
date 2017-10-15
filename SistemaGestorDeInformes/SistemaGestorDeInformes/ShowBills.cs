using System;
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
        private ProviderController providerController;
        public ShowBills()
        {
            InitializeComponent();
            invoiceController = new InvoiceController();
            providerController = new ProviderController();
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
            dataGridView1.Columns["Proveedor"].ReadOnly = true;
        }

        private void ShowBills_Load(object sender, EventArgs e)
        {
            chargeData();
            onlyReadRestrictionDataGrid();
        }

        private void chargeData()
        {
            List<Invoice> invoices = invoiceController.getAllInvoices();
            foreach (Invoice invoice in invoices)
            {
                String nInvo = invoice.getNInvoice() + "",
                       nAuto = invoice.getNAutorization() + "",
                       nit = invoice.getProvider().getNit() + "",
                       date = invoice.getDate().ToShortDateString(),
                       providersName = invoice.getProvider().getName();

                String[] row = new String[] {nInvo,nAuto,providersName,nit,date};
                dataGridView1.Rows.Add(row);
            }
        }

        private String invoiceRowsToString(List<InvoiceRow> rows)
        {
            String output = "";
            foreach (InvoiceRow row in rows)
            {
                output +=row+"\n";
            }
            return output;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String providersName= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            int nInvoice = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int providerId = providerController.findProviderIdByName(providersName);
            Invoice invoice = invoiceController.getInvoiceByNInvoiceAndProviderId(nInvoice,providerId);
            openModify(invoice);
        }

        private void openModify(Invoice invoice)
        {
            InterfazRegistrarFactura inF = new InterfazRegistrarFactura(invoice);
            this.Hide();
            inF.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInventory ShowInventory1 = new ShowInventory();
            this.Hide();
            ShowInventory1.Show();
        }
    }
}
