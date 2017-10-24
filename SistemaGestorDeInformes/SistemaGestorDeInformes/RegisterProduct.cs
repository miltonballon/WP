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
    public partial class RegisterProduct : Form
    {
        ProductController pc;
        Product p;
        public RegisterProduct()
        {
            InitializeComponent();
            pc = new ProductController();
        
            
        }

        private void labelProveedor_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            InterfazPrincipal main = new InterfazPrincipal();
            main.WindowState = this.WindowState;
            this.Hide();
            main.Show();
        }

        private void ShowProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts main = new ShowProducts();
            main.WindowState = this.WindowState;
            this.Hide();
            main.Show();
        }

        void RegisterButton_Click(object sender, EventArgs e)
        {
            Product product = new Product(ProductTextBox.Text, ProviderTextBox.Text, Unit.Text);
            pc.insertProduct(product);
            pc.addReferencesToTableProduct_Provider_Unit(product);
            cleanTextBox();
            MessageBox.Show("Agregado exitosamente");

        }
        public void cleanTextBox()
        {
            ProductTextBox.Text = "";
            ProviderTextBox.Text = "";
            Unit.Text = "";
        }

        private void MainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipal MainForm = new InterfazPrincipal();
            MainForm.WindowState = this.WindowState;
            MainForm.Show();
            this.Hide();
        }

        private void RegisterInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazRegistrarFactura RegisterInvoiceForm = new InterfazRegistrarFactura();
            RegisterInvoiceForm.WindowState = this.WindowState;
            RegisterInvoiceForm.Show();
            this.Hide();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBills ShowBills1 = new ShowBills();
            ShowBills1.WindowState = this.WindowState;
            ShowBills1.Show();
            this.Hide();
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

        private void RegisterProduct_Load(object sender, EventArgs e)
        {

        }

        private void generarInformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReport Interfaz = new GenerateReport();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void RegisterProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
