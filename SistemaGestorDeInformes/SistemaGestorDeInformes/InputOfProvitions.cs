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
            rc.RegisterReception(ProducTextBox,ProviderTextBox,UnitTextBox,ExpirationDate,ReceptionDate,TotalReception);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InterfazPrincipal main = new InterfazPrincipal();
            this.Hide();
            main.Show();
        }

        private void RegisterReception_Load(object sender, EventArgs e)
        {
            rc.ProductAutoComplete(ProducTextBox);
            rc.ProviderAutoComplete(ProviderTextBox);
            rc.UnitAutoComplete(UnitTextBox);
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
            this.Hide();
            principal.Show();
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipal Interfaz = new InterfazPrincipal();
            this.Hide();
            Interfaz.Show();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazRegistrarFactura Interfaz = new InterfazRegistrarFactura();
            this.Hide();
            Interfaz.Show();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBills Interfaz = new ShowBills();
            this.Hide();
            Interfaz.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct Interfaz = new RegisterProduct();
            this.Hide();
            Interfaz.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts Interfaz = new ShowProducts();
            this.Hide();
            Interfaz.Show();
        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInventory Interfaz = new ShowInventory();
            this.Hide();
            Interfaz.Show();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfiguration Interfaz = new ReportConfiguration();
            this.Hide();
            Interfaz.Show();
        }

        private void abrirTrimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenQuarter Interfaz = new OpenQuarter();
            this.Hide();
            Interfaz.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}
