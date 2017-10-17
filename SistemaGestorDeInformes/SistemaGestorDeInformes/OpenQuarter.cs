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
            InterfazPrincipal principal = new InterfazPrincipal();//para volver atras
            this.Hide();
            principal.Show();
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipal principal = new InterfazPrincipal();
            this.Hide();
            principal.Show();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazRegistrarFactura intRegFac = new InterfazRegistrarFactura();
            this.Hide();
            intRegFac.Show();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBills ShowBills1 = new ShowBills();
            this.Hide();
            ShowBills1.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct RegisterProduct1 = new RegisterProduct();
            this.Hide();
            RegisterProduct1.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts ShowProducts1 = new ShowProducts();
            this.Hide();
            ShowProducts1.Show();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfiguration ReportConfiguration1 = new ReportConfiguration();
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

        private void labelInformaciónBásica_Click(object sender, EventArgs e)
        {

        }

        private void OpenQuarter_Load(object sender, EventArgs e)
        {
            setLbTrimText();
            hideNombreForms();
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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void registrarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputOfProvitions InputOfProvitions1 = new InputOfProvitions();
            this.Hide();
            InputOfProvitions1.Show();
        }

        private void registrarSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputOfProvitions Interfaz = new OutputOfProvitions();
            this.Hide();
            Interfaz.Show();
        }
    }
}
