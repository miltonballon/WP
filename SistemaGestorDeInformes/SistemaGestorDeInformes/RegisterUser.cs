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
    
    public partial class RegisterUser : Form
    {
        UserController userController;
        public RegisterUser()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            User user = new User(txtName.Text, txtEmail.Text, txtPassword.Text);
            if (userController.CreateUser(user))
            {
                MessageBox.Show("Usuario creado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }



        }
    }
}
