﻿using System;
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
    public partial class ReportConfiguration : Form
    {
        private ConfigurationController configurationController;

        public ReportConfiguration()
        {
            InitializeComponent();
            configurationController = new ConfigurationController();
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main principal = new Main();
            principal.WindowState = this.WindowState;
            principal.Show();
            this.Hide();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterInvoice InterfazRegistrarFactura1 = new RegisterInvoice();
            InterfazRegistrarFactura1.WindowState = this.WindowState;
            InterfazRegistrarFactura1.Show();
            this.Hide();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBills ShowBills1 = new ShowBills();
            ShowBills1.WindowState = this.WindowState;
            ShowBills1.Show();
            this.Hide();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct RegisterProduct1 = new RegisterProduct();
            RegisterProduct1.WindowState = this.WindowState;
            RegisterProduct1.Show();
            this.Hide();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts ShowProducts1 = new ShowProducts();
            ShowProducts1.WindowState = this.WindowState;
            ShowProducts1.Show();
            this.Hide();
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

        private void generarInformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReport Interfaz = new GenerateReport();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void ReportConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void ReportConfiguration_Load(object sender, EventArgs e)
        {
            becas_Textbox.MaxLength = 70;
            NPartida_textbox.MaxLength = 70;

            becas_Textbox.ShortcutsEnabled = false;
            NPartida_textbox.ShortcutsEnabled = false;

            FillLabels();

            KeyPreview = true;
        }

        private void FillLabels()
        {
            Configuration configuration = configurationController.GetConfiguration();
            if (configuration != null)
            {
                String schollarships = configuration.getScholarships() + "",
                departure = configuration.getNDeparture() + "";
                lbBecas.Text = "Datos actuales: "+schollarships;
                lbPartida.Text = "Datos actuales:"+departure;
            }
            else
            {
                lbBecas.Text = "Sin Datos";
                lbPartida.Text = "Sin Datos";
            }
        }

        private void ReportConfiguration_KeyUp(object sender, KeyEventArgs e)
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

        private void becas_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0')
                e.Handled = true;
        }

        private void NPartida_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0')
                e.Handled = true;
        }

        private void Registrar_Button_Click(object sender, EventArgs e)
        {
            int nScho = Int32.Parse(becas_Textbox.Text),
                nPar = Int32.Parse(NPartida_textbox.Text);
            Configuration conf = new Configuration(nScho, nPar);
            configurationController.insertConfiguration(conf);
            FillLabels();
            MessageBox.Show("Se guardo la configuración correctamente");
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

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoricReceptions Interfaz = new HistoricReceptions();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }
    }
}
