﻿using System;
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
    public partial class ModifyProduct : Form
    {
        ProductController pc;
        public ModifyProduct()
        {
            InitializeComponent();
            pc = new ProductController();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            Product product = new Product(ProductTextBox.Text, ProviderTextBox.Text, Unit.Text);
            pc.insertProduct(product);
            pc.addReferencesToTableProduct_Provider_Unit(product);
            ShowProducts ShowProducts1 = new ShowProducts();
            ShowProducts1.WindowState = this.WindowState;
            this.Hide();
            ShowProducts1.Show();
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            Product product = new Product(ProductTextBox.Text, ProviderTextBox.Text, Unit.Text);
            pc.insertProduct(product);
            pc.addReferencesToTableProduct_Provider_Unit(product);
            MessageBox.Show("Editado exitosamente");
            ShowProducts main = new ShowProducts();
            main.WindowState = this.WindowState;
            main.Show();
            this.Hide();
        }
    }
}
