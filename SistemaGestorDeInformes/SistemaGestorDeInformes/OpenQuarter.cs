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
    public partial class OpenQuarter : Form
    {
        private TrimesterController trimesterController;
        private bool isRegistering;
        public OpenQuarter()
        {
            InitializeComponent();
            trimesterController = new TrimesterController();
            isRegistering = false;
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            Main principal = new Main();//para volver atras
            principal.WindowState = this.WindowState;
            this.Hide();
            principal.Show();
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main principal = new Main();
            principal.WindowState = this.WindowState;
            this.Hide();
            principal.Show();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterInvoice intRegFac = new RegisterInvoice();
            intRegFac.WindowState = this.WindowState;
            this.Hide();
            intRegFac.Show();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBills ShowBills1 = new ShowBills();
            ShowBills1.WindowState = this.WindowState;
            this.Hide();
            ShowBills1.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct RegisterProduct1 = new RegisterProduct();
            RegisterProduct1.WindowState = this.WindowState;
            this.Hide();
            RegisterProduct1.Show();
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

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            if (isRegistering)
            {
                String name = txbxNombre.Text;
                if (!name.Equals(""))
                {
                    Trimester trimester = new Trimester(name);
                    trimester.setOpen(true);
                    saveNewTrimester(trimester);
                    hideNombreForms();
                    RegistrarButton.Text = "Nuevo Trimestre";
                    setLbTrimText();
                    MessageBox.Show("Nuevo trimestre creado: "+trimester.getName());
                    isRegistering = !isRegistering;
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre para el trimestre");
                }
            }
            else
            {
                showNombreForms();
                RegistrarButton.Text = "Guardar";
                isRegistering = !isRegistering;
            }
        }

        private void saveNewTrimester(Trimester trimester)
        {
            Trimester last=trimesterController.getLastTrimester();
            if (last != null)
            {
                last.setOpen(false);
                trimesterController.updateTrimester(last);
            }
            trimesterController.insertTrimester(trimester);
        }
        

        private void OpenQuarter_Load(object sender, EventArgs e)
        {
            setLbTrimText();
            hideNombreForms();

            txbxNombre.MaxLength = 70;
            txbxNombre.ShortcutsEnabled = false;

            KeyPreview = true;
        }

        private void setLbTrimText()
        {
            Trimester trimester=trimesterController.getLastTrimester();
            if (trimester != null)
            {
                lbTrim.Text = trimester.getName();
            }
            else
            {
                lbTrim.Text = "No se encontraron Trimestres, cree uno";
            }
        }

        private void hideNombreForms()
        {
            lbNombre.Hide();
            txbxNombre.Hide();
        }

        private void showNombreForms()
        {
            lbNombre.Show();
            txbxNombre.Show();
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
        
        private void OpenQuarter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OpenQuarter_KeyUp(object sender, KeyEventArgs e)
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
    }
}
