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
    public partial class OutputOfProvitions : Form
    {
        public OutputOfProvitions()
        {
            InitializeComponent();
        }

        private void buttonAtrás_Click(object sender, EventArgs e)
        {
            InterfazPrincipal main = new InterfazPrincipal();
            this.Hide();
            main.Show();
        }

        private void registrarSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void registrarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputOfProvitions Interfaz = new InputOfProvitions();
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
            Login Interfaz = new Login();
            this.Hide();
            Interfaz.Show();
        }
    }
}
