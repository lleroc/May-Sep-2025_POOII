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
    public partial class FRMNuevoUsuario : Form
    {
        private Aplicacion.UsuarioService _usuarioService = new Aplicacion.UsuarioService();
        public FRMNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var user = new Datos.UsuarioDTO
            {
                Correo = txtCorreo.Text.Trim(),
                Nombre = txtnombre.Text.Trim(),
                password = txtContrasenia.Text.Trim()
            };
            //string res = _usuarioService.insertar(user);
            //if (res == "ok")
            if (_usuarioService.insertar(user) == "ok")
            {
                MessageBox.Show("Se guardo con exito");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al guadar");
            }
        }
    }
}
