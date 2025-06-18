﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login
{
    public partial class Form1 : Form
    {
        Controllers.AuthController _authController = new Controllers.AuthController();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var usuario = new Models.LoginModel
            {
                NombreUsuario = txtUsuario.Text.Trim(),
                Contrasenia = txtContrasenia.Text.Trim()
            };
            var res = _authController.login(usuario);
            if (res == "ok")
            {
                MessageBox.Show("Bievenido al Sistema");
                //enviar a abrir al formulario de dashboard
                var frmMenuPrincipal = new Vistas.FRM_MenuPrincipal();
                this.Hide();  //oculta el forrmulario
                frmMenuPrincipal.Show();
            }
            else {
                MessageBox.Show(res);
                lblMensaje.Text = res;
                lblMensaje.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   //para cerrar la aplicaicon
            
            txtContrasenia.Text = "";
            txtUsuario.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = new Models.LoginModel
            {
                NombreUsuario = txtUsuario.Text.Trim(),
                Contrasenia = txtContrasenia.Text.Trim()
            };
            var res = _authController.login2(usuario);
            if (res == "ok")
            {
                MessageBox.Show("Bievenido al Sistema");
                //enviar a abrir al formulario de dashboard
                var frmMenuPrincipal = new Vistas.FRM_MenuPrincipal();
                this.Hide();  //oculta el forrmulario
                frmMenuPrincipal.Show();
            }
            else
            {
                MessageBox.Show(res);
                lblMensaje.Text = res;
                lblMensaje.Visible = true;
            }
        }
    }
}
