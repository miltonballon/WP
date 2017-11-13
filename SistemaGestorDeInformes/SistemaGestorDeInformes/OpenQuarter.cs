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
            setLbTrimText();
            hideCreationForms();
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

        private void saveNewTrimester(Trimester trimester)
        {
            Trimester last=trimesterController.GetLastTrimester();
            if (last != null)
            {
                last.SetOpen(false);
                trimesterController.UpdateTrimester(last);
            }
            trimesterController.InsertTrimester(trimester);
        }
        

        private void OpenQuarter_Load(object sender, EventArgs e)
        {
            setLbTrimText();
            hideCreationForms();

            Nombre_Textbox.MaxLength = 70;
            Nombre_Textbox.ShortcutsEnabled = false;

            KeyPreview = true;
        }

        private void setLbTrimText()
        {
            Trimester trimester=trimesterController.GetLastTrimester();
            if (trimester != null)
            {
                lbTrim.Text = trimester.ToString();
            }
            else
            {
                lbTrim.Text = "No se encontraron Trimestres, cree uno";
            }
        }

        private void hideCreationForms()
        {
            lbNombre.Hide();
            Nombre_Textbox.Hide();
            lbFecFin.Hide();
            DTPicker_Fin.Hide();
            DTPicker_Inicio.Hide();
            lbFecIni.Hide();
            int xPosition = 299,
                yPosition = 229;
            Registrar_Button.Location = new Point(xPosition, yPosition);
        }

        private void showCreationForms()
        {
            lbNombre.Show();
            Nombre_Textbox.Show();
            lbFecFin.Show();
            DTPicker_Fin.Show();
            DTPicker_Inicio.Show();
            lbFecIni.Show();
            int xPosition= Registrar_Button.Location.X, 
                yPosition= Registrar_Button.Location.Y+25;
            Registrar_Button.Location = new Point(xPosition,yPosition);
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

        private void Registrar_Button_Click(object sender, EventArgs e)
        {
            if (isRegistering)
            {
                String name = Nombre_Textbox.Text;
                DateTime initial=DTPicker_Inicio.Value, 
                    end=DTPicker_Fin.Value;
                if (!name.Equals(""))
                {
                    Trimester trimester = new Trimester(name,initial,end);
                    trimester.SetOpen(true);
                    saveNewTrimester(trimester);
                    hideCreationForms();
                    Registrar_Button.Text = "Nuevo Trimestre";
                    setLbTrimText();
                    MessageBox.Show("Nuevo trimestre creado: " + trimester.GetName());
                    isRegistering = !isRegistering;
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre para el trimestre");
                }
            }
            else
            {
                showCreationForms();
                Registrar_Button.Text = "Guardar";
                isRegistering = !isRegistering;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProvider Interfaz = new RegisterProvider();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }
    }
}
