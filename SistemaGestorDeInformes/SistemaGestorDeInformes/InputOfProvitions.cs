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

namespace SistemaGestorDeInformes
{
    public partial class InputOfProvitions : Form
    {

        ReceptionController rc;
        public InputOfProvitions()
        {
            rc = new ReceptionController();
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Product product = new Product(ProducTextBox.Text, ProviderTextBox.Text, UnitTextBox.Text);

            Reception reception = new Reception(product, ExpirationDate.Value.ToString("dd/MM/yyyy"), ReceptionDate.Value.ToString("dd/MM/yyyy"), Int32.Parse(TotalReception.Text));
           // rc.RegisterReception(ProducTextBox,ProviderTextBox,UnitTextBox,ExpirationDate,ReceptionDate,TotalReception);
            rc.RegisterReception(reception);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            InterfazPrincipal main = new InterfazPrincipal();
            main.WindowState = this.WindowState;
            this.Hide();
            main.Show();
        }

        private void RegisterReception_Load(object sender, EventArgs e)
        {
            rc.ProductAutoComplete(ProducTextBox);
            rc.ProviderAutoComplete(ProviderTextBox);
            rc.UnitAutoComplete(UnitTextBox);

            ProducTextBox.MaxLength = 70;
            ProviderTextBox.MaxLength = 70;
            UnitTextBox.MaxLength = 3;
            TotalReception.MaxLength = 15;

            ProducTextBox.ShortcutsEnabled = false;
            ProviderTextBox.ShortcutsEnabled = false;
            UnitTextBox.ShortcutsEnabled = false;
            TotalReception.ShortcutsEnabled = false;

            KeyPreview = true;
        }

        private void ProducTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TotalReception_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExpirationDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProviderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAtrás_Click(object sender, EventArgs e)
        {
            InterfazPrincipal principal = new InterfazPrincipal();//para volver atras
            principal.WindowState = this.WindowState;
            this.Hide();
            principal.Show();
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipal Interfaz = new InterfazPrincipal();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazRegistrarFactura Interfaz = new InterfazRegistrarFactura();
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

        private void ProducTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void UnitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }               
        
        private void TotalReception_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0')
                e.Handled = true;
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            InterfazPrincipal main = new InterfazPrincipal();
            main.WindowState = this.WindowState;
            this.Hide();
            main.Show();
        }

        private void InputOfProvitions_KeyUp(object sender, KeyEventArgs e)
        {
            InterfazPrincipal prin = new InterfazPrincipal();
            ValidationTextBox tr = new ValidationTextBox();
            tr.KeyEscape(sender, e, this, prin);
        }
    }
}
