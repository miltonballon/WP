using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerLibrary;
using EntityLibrary;

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
            Main principal = new Main();
            principal.WindowState = this.WindowState;
            principal.Show();
            this.Hide();
        }

         private void MainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main MainForm = new Main();
            MainForm.WindowState = this.WindowState;
            MainForm.Show();
            this.Hide();
        }

        private void RegisterInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterInvoice RegisterInvoiceForm = new RegisterInvoice();
            RegisterInvoiceForm.WindowState = this.WindowState;
            RegisterInvoiceForm.Show();
            this.Hide();
        }

        private void registrarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterInvoice intRegFac = new RegisterInvoice();
            intRegFac.WindowState = this.WindowState;
            this.Hide();
            intRegFac.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct intRegisterProduct = new RegisterProduct();
            intRegisterProduct.WindowState = this.WindowState;
            intRegisterProduct.Show();
            this.Hide();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts ShowProducts1 = new ShowProducts();
            ShowProducts1.WindowState = this.WindowState;
            this.Hide();
            ShowProducts1.Show();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfiguration ReportConfiguration1 = new ReportConfiguration();
            ReportConfiguration1.WindowState = this.WindowState;
            this.Hide();
            ReportConfiguration1.Show();
        }

        private void abrirTrimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenQuarter OpenQuarter1 = new OpenQuarter();
            OpenQuarter1.WindowState = this.WindowState;
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

            KeyPreview = true;
        }

        private void chargeData()
        {
            List<Invoice> invoices = invoiceController.GetAllInvoices();
            
            foreach (Invoice invoice in invoices)
            {
                String nInvo = invoice.GetNInvoice() + "",
                       nAuto = invoice.GetNAutorization() + "",
                       nit = invoice.GetProvider().GetNit() + "",
                       date = invoice.GetDate().ToShortDateString(),
                       providersName = invoice.GetProvider().GetName();

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
            int providerId = providerController.FindProviderIdByName(providersName);
            Invoice invoice = invoiceController.GetInvoiceByNInvoiceAndProviderId(nInvoice,providerId);
            openModify(invoice);
        }

        private void openModify(Invoice invoice)
        {
            RegisterInvoice inF = new RegisterInvoice(invoice);
            inF.WindowState = this.WindowState;
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
            ShowInventory1.WindowState = this.WindowState;
            this.Hide();
            ShowInventory1.Show();
        }

        private void registrarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputOfProvitions InputOfProvitions1 = new InputOfProvitions();
            InputOfProvitions1.WindowState = this.WindowState;
            this.Hide();
            InputOfProvitions1.Show();
        }

        private void registrarSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputOfProvitions Interfaz = new OutputOfProvitions();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void generarInformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReport Interfaz = new GenerateReport();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void ShowBills_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ShowBills_KeyUp(object sender, KeyEventArgs e)
        {
            Main prin = new Main();
            ValidationTextBox tr = new ValidationTextBox();
            tr.KeyEscape(sender, e, this, prin);
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InventoryConfiguration Interfaz = new InventoryConfiguration();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void Atras_Button_Click(object sender, EventArgs e)
        {
            Main principal = new Main();//para volver atras
            principal.WindowState = this.WindowState;
            this.Hide();
            principal.Show();
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProvider Interfaz = new RegisterProvider();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void verProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProviders Interfaz = new ShowProviders();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }
    }
}
