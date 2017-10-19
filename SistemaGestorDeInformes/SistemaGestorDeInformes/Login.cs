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
    public partial class Login : Form
    {
        private UserController usercontroller;
        private User user;
        public Login()
        {
            InitializeComponent();
            usercontroller = new UserController();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String username = txtUsuario.Text;
            if (username != "")
            {
                User user = usercontroller.getUserByUsername(username);
                if (user != null)
                {
                    this.Hide();
                    RestablecerContraseñaForm CC = new RestablecerContraseñaForm(user);
                    CC.ShowDialog();
                    //this.Show();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario inexistente");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nombre de usuario");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String user = txtUsuario.Text;
            String pass = txtContraseña.Text;
            if (user != "" && pass != "")
            {
                if (usercontroller.verify(user, pass))
                {
                    InterfazPrincipal prin = new InterfazPrincipal();
                    this.Hide();
                    prin.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no existe o la contraseña es incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String user = txtUsuario.Text;
                String pass = txtContraseña.Text;
                if (user != "" && pass != "")
                {
                    if (usercontroller.verify(user, pass))
                    {
                        InterfazPrincipal prin = new InterfazPrincipal();
                        this.Hide();
                        prin.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe o la contraseña es incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor llene todos los campos");
                }
            }
        }
    }
}
