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
    public partial class FRMEditarUsuario : Form
    {
        public int _usuarioId;
        private Aplicacion.UsuarioService _usuarioService = new Aplicacion.UsuarioService();
        public FRMEditarUsuario(int UsuarioId)
        {
            InitializeComponent();
            _usuarioId = UsuarioId;
        }

        private void FRMEditarUsuario_Load(object sender, EventArgs e)
        {
            Datos.UsuarioDTO usuario = _usuarioService.uno(_usuarioId);
            txtContrasenia.Text = usuario.password;
            txtCorreo.Text = usuario.Correo;
            txtnombre.Text = usuario.Nombre;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string res = _usuarioService.editar(new Datos.UsuarioDTO
            {
                Correo = txtCorreo.Text.Trim(),
                Nombre = txtnombre.Text.Trim(),
                password = txtContrasenia.Text.Trim(),
                UsuarioId = _usuarioId
            });
            if (res == "ok")
            {
                MessageBox.Show("Se aactualizo el usuario con exito");
                this.limpiarcajas();
                this.Close();
            }
        }
        public void limpiarcajas()
        {
            txtContrasenia.Text = "";
            txtCorreo.Text = "";
            txtnombre.Text = "";

        }
    }
}
