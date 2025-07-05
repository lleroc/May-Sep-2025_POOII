using EfCore_Code_Firts.Controllers;
using EfCore_Code_Firts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfCore_Code_Firts.Views.Administracion
{
    public partial class FRM_Usuarios : Form
    {
        private readonly UsuarioController _usuarioController;
        public FRM_Usuarios()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();
        }

        private void FRM_Usuarios_Load(object sender, EventArgs e)
        {
            CargaLissta();
        }
        public void CargaLissta()
        {
            //lstUsuarios.Items.Clear();
            lstUsuarios.DataSource = _usuarioController.todos();
            lstUsuarios.DisplayMember = "Nombre_Usuario";
            lstUsuarios.ValueMember = "Id";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var res = "";
            var usuario = new UsuarioModel
            {
                Nombre_Usuario = txtNombre.Text,
                Apellido_Usuario = txtApellido.Text,
                Rol_Usuario = cmbRol.SelectedText,
                Contrasenia = txtContrasenia.Text
            };

            if (lstUsuarios.Enabled == false)
            {
                usuario.Id = Convert.ToInt32(lstUsuarios.SelectedValue);
                res = _usuarioController.actualizar(usuario);
            }
            else
            {
                res = _usuarioController.Insertar(usuario);
            }

            if (res == "ok")
            {
                MessageBox.Show("Se guardo con exito");
                LimpiaCajas();
                CargaLissta();
            }
            else
            {
                lblErrores.Text = res;
                lblErrores.Visible = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuairo de la lista");
                return;
            }
            lstUsuarios.Enabled = false;
            var usuario = _usuarioController.uno(Convert.ToInt32(lstUsuarios.SelectedValue));
            txtApellido.Text = usuario.Apellido_Usuario;
            txtNombre.Text = usuario.Nombre_Usuario;
            txtContrasenia.Text = usuario.Contrasenia;
            cmbRol.SelectedText = usuario.Rol_Usuario;
        }
        public void LimpiaCajas()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtContrasenia.Text = "";
            lstUsuarios.Enabled = true;
            lblErrores.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiaCajas();
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuairo de la lista");
                return;
            }
            if (_usuarioController.Eliminar(Convert.ToInt32(lstUsuarios.SelectedValue)) == "ok")
            {
                MessageBox.Show("Se elimino con exito");
                CargaLissta();
            }
            else {
                MessageBox.Show("Ocurrio un error");
            }
        }
    }
}
