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
    public partial class InputOfProvitions : Form
    {

        ReceptionController rc;
        Product product;
        public InputOfProvitions()
        {
            rc = new ReceptionController();
            InitializeComponent();
            product = new Product();
        }
       

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
            Inventory inventory = new Inventory(product, Int32.Parse(TotalReception_Textbox.Text), ExpirationDate.Value.ToString("dd/MM/yyyy"));

        }        
       
        private void RegisterReception_Load(object sender, EventArgs e)
        {
            rc.ProductAutoComplete(Produc_TextBox);
            rc.ProviderAutoComplete(Provider_TextBox);
            rc.UnitAutoComplete(Unit_TextBox);

            Produc_TextBox.MaxLength = 70;
            Provider_TextBox.MaxLength = 70;
            Unit_TextBox.MaxLength = 20;
            TotalReception_Textbox.MaxLength = 15;

            Produc_TextBox.ShortcutsEnabled = false;
            Provider_TextBox.ShortcutsEnabled = false;
            Unit_TextBox.ShortcutsEnabled = false;
            TotalReception_Textbox.ShortcutsEnabled = false;

            KeyPreview = true;
        }                

        private void buttonAtrás_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.WindowState = this.WindowState;
            this.Hide();
            main.Show();
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main Interfaz = new Main();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterInvoice Interfaz = new RegisterInvoice();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBills Interfaz = new ShowBills();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct Interfaz = new RegisterProduct();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts Interfaz = new ShowProducts();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInventory Interfaz = new ShowInventory();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfiguration Interfaz = new ReportConfiguration();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void abrirTrimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenQuarter Interfaz = new OpenQuarter();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
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

        private void InputOfProvitions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void TotalReception_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 08 && e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0')
                e.Handled = true;
        }

        private void InputOfProvitions_KeyUp(object sender, KeyEventArgs e)
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

        private void Produc_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationTextBox tr = new ValidationTextBox();
            tr.CharacterEspecial(sender, e);
        }

        private void Provider_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationTextBox tr = new ValidationTextBox();
            tr.CharacterEspecial(sender, e);
        }

        private void Unit_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationTextBox tr = new ValidationTextBox();
            tr.CharacterEspecial(sender, e);
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            product.Name = Produc_TextBox.Text;
            product.Provider = Provider_TextBox.Text;
            product.Unit = Unit_TextBox.Text;

            Reception reception = new Reception(product, ExpirationDate.Value.ToString("dd/MM/yyyy"), ReceptionDate.Value.ToString("dd/MM/yyyy"), Int32.Parse(TotalReception_Textbox.Text));
            rc.RegisterReception(reception);
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

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoricReceptions Interfaz = new HistoricReceptions();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void ExpirationDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
