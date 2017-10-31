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
    public partial class OutputOfProvitions : Form
    {
        OutputReceptionController rc;
        public OutputOfProvitions()
        {
            rc = new OutputReceptionController();
            InitializeComponent();
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

        private void registrarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputOfProvitions Interfaz = new InputOfProvitions();
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
            Login Interfaz = new Login();
            this.Hide();
            Interfaz.Show();
        }

        private void OutputOfProvitions_Load(object sender, EventArgs e)
        {
            rc.ProductAutoComplete(Product_TextBox);
            rc.UnitAutoComplete(Unit_TextBox);

            Product_TextBox.MaxLength = 70;
            UnitTextBox.MaxLength = 20;
            Total_TextBox.MaxLength = 15;
            OutputDate_TextBox.MaxLength = 10;

            Product_TextBox.ShortcutsEnabled = false;
            Unit_TextBox.ShortcutsEnabled = false;
            Total_TextBox.ShortcutsEnabled = false;
            OutputDate_TextBox.ShortcutsEnabled = false;

            KeyPreview = true;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //rc.RegisterOutputReception(ProductTextBox, UnitTextBox, OutputDateTextBox, TotalTextBox);
            OutputReception outputReception = new OutputReception();
            outputReception.Reception.Product.Name = ProductTextBox.Text;
            outputReception.Reception.Product.Unit = UnitTextBox.Text;
            outputReception.OutputDate = OutputDateTextBox.Text;
            outputReception.Total = Int32.Parse(TotalTextBox.Text);

            rc.InsertOutputReceptionAndInventory(outputReception);
        private void generarInformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReport Interfaz = new GenerateReport();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void OutputOfProvitions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

                

        private void OutputOfProvitions_KeyUp(object sender, KeyEventArgs e)
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

        private void Product_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar == 47))
            ValidationTextBox tr = new ValidationTextBox();
            tr.CharacterEspecial(sender, e);
        }

        private void Unit_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationTextBox tr = new ValidationTextBox();
            tr.CharacterEspecial(sender, e);
        }

        private void Total_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 08 && e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0')
                e.Handled = true;
        }

        private void OutputDate_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationTextBox tr = new ValidationTextBox();
            tr.CharacterEspecial(sender, e);
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            rc.RegisterOutputReception(Product_TextBox, Unit_TextBox, OutputDate_TextBox, Total_TextBox);
        }
    }
}
