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
    public partial class RegisterProduct : Form
    {
        ProductController pc;
        Product product;
        public RegisterProduct()
        {
            InitializeComponent();
            pc = new ProductController();
            product = new Product();
        }
        

        private void BackButton_Click(object sender, EventArgs e)
        {
            Main main = new Main();
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
           
            product.Name = ProductTextBox.Text;
            product.Provider=ProviderTextBox.Text;
            product.Unit= Unit.Text;

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
            ProductTextBox.MaxLength = 70;
            ProviderTextBox.MaxLength = 70;
            Unit.MaxLength = 20;

            ProductTextBox.ShortcutsEnabled = false;
            ProviderTextBox.ShortcutsEnabled = false;
            Unit.ShortcutsEnabled = false;


            KeyPreview = true;
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

        private void ProductTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ProviderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void RegisterProduct_KeyUp(object sender, KeyEventArgs e)
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

        private void FreshRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            product.Clasification = "Fresco";
        }

        private void DryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            product.Clasification="Seco";
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
