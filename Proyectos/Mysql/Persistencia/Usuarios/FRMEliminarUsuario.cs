using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysql.Persistencia.Usuarios
{
    public partial class FRMEliminarUsuario : Form
    {
        public int _usuarioId;
        private Aplicacion.UsuarioService _usuarioService = new Aplicacion.UsuarioService();
        public FRMEliminarUsuario()
        {
            InitializeComponent();
        }

        private void FRMEliminarUsuario_Load(object sender, EventArgs e)
        {
            Datos.UsuarioDTO usuarioDTO = _usuarioService.uno(_usuarioId);
            lblCorreo.Text = usuarioDTO.Correo;
            lblNombre.Text = usuarioDTO.Nombre;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado =
                MessageBox.Show($"Desea Eliminar al usaurio {lblNombre.Text}",
                "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (resultado == DialogResult.Yes)
            {
                if (_usuarioService.elimnar(_usuarioId) == "ok")
                {
                    MessageBox.Show($"Se elimino al usuario {lblNombre.Text}");
                }
                else { 
                    MessageBox.Show($"Ocurrio un error al eleminar");
                }
            }
            else
            {
                MessageBox.Show("El procedimiento fue cancelado por el usuario");
            }
        }
    }
}
