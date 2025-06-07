using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_proimea_vez
{
    public partial class login : Form
    {
        Controladores.AuthController _authController = new Controladores.AuthController();
        Modelos.Login _login = new Modelos.Login();

        Controladores.UsuariosController _usuariosController = 
            new Controladores.UsuariosController();
        public login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var log = _authController.Login(txtUsuario.Text.Trim(), txtPassword.Text.Trim());

            if (log)
            {
                Vistas.Menu_Principal menu_Principal = new Vistas.Menu_Principal();
                this.Hide();
                menu_Principal.Show();
            }
            else {
                MessageBox.Show("Error al Iniciar Sesion");
            }
        }

        public void ListaUsuarios() {

            for (int i = 0; i < 10; i++)
            {
                var usr = new Modelos.Usuarios
                {
                    Apellido = "Llrena",
                    Nombre = "Luis " + i.ToString(),
                    Contrasenia = "123",
                    correo = "Cooreo@gmail.com",
                    Estado = true,
                    Nombre_Usuario = "lleroc",
                };
                _usuariosController.insertar(usr);
            }

            var listaUsuario = _usuariosController.todos().ToList();
            lstUsuarios.DataSource = listaUsuario;
            lstUsuarios.ValueMember = "UsuarioId";
            lstUsuarios.DisplayMember = "Nombre";
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ListaUsuarios();
        }
    }
}
