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
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();
        }

        private void ViewReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
