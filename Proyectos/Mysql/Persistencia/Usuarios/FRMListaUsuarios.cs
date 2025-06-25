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
    public partial class FRMListaUsuarios : Form
    {
        private readonly Aplicacion.UsuarioService _usuarioService = new Aplicacion.UsuarioService();
        public FRMListaUsuarios()
        {
            InitializeComponent();
        }

        private void FRMListaUsuarios_Load(object sender, EventArgs e)
        {
           this.cargaLista();
        }

        public void cargaLista() {
            lstUsuarios.DataSource = _usuarioService.todos().ToList();
            lstUsuarios.DisplayMember = "Nombre";
            lstUsuarios.ValueMember = "UsuarioId";
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            var fRMNuevoUsuario = new FRMNuevoUsuario();
            fRMNuevoUsuario.ShowDialog();
        }

        private void FRMListaUsuarios_Activated(object sender, EventArgs e)
        {
            this.cargaLista();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1) 
            {
                MessageBox.Show("Seleccione un usaurio de la lista");
                return;
            }

            if (_usuarioService.elimnar(Convert.ToInt32(lstUsuarios.SelectedValue)) == "ok")
            {
                MessageBox.Show("Se elimino con exito");
                this.cargaLista();
            }else
            {
                MessageBox.Show("Ocurrio un error al eliminar");
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario de la lista");
                lstUsuarios.Focus();
                return;
            }
            FRMEditarUsuario fRMEditarUsuario = new FRMEditarUsuario(Convert.ToInt32(lstUsuarios.SelectedValue));
            fRMEditarUsuario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usaurio de la lista");
            }
            else {
                FRMEliminarUsuario fRMEliminarUsuario = new FRMEliminarUsuario();
                fRMEliminarUsuario._usuarioId = Convert.ToInt32(lstUsuarios.SelectedValue);
                fRMEliminarUsuario.Show();
            }
        }
    }
}
