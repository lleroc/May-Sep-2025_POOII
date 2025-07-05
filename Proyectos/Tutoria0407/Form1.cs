using Tutoria0407.Controllers;
using Tutoria0407.Models;

namespace Tutoria0407
{
    public partial class Form1 : Form
    {
        private readonly PaisController _paisController;
        public Form1()
        {
            InitializeComponent();
            _paisController = new PaisController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarLista();
        }
        public void llenarLista()
        {
            lstPaises.DataSource = _paisController.todos();
            lstPaises.DisplayMember = "Detalle";
            lstPaises.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var res = "";
            var pais = new PaisModel
            {
                Detalle = txtDetalle.Text
            };
            if (lstPaises.Enabled == true)
            {
                res = _paisController.insertar(pais);
            }
            else
            {
                pais.Id = Convert.ToInt32(lstPaises.SelectedValue);
                res = _paisController.actualizar(pais);
            }
            if (res == "ok")
            {
                MessageBox.Show("Se guardo con exito");
                txtDetalle.Text = "";
                llenarLista();
                limpiacajas();
            }
            else
            {
                MessageBox.Show($"Ocurrio un error {res}");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstPaises.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccion un pais de la lista");
                return;
            }
            lstPaises.Enabled = false;
            var res = _paisController.uno(Convert.ToInt32(lstPaises.SelectedValue));
            txtDetalle.Text = res.Detalle;
        }
        public void limpiacajas()
        {
            txtDetalle.Text = "";
            lstPaises.Enabled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiacajas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var res = "";
            if (lstPaises.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccion un pais de la lista");
                return;
            }
            var respuesta = MessageBox.Show("Eliminar Paises", "Desea Eliminar el Pais",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (respuesta == DialogResult.Yes) {
                 res = _paisController.eliminar(Convert.ToInt32(lstPaises.SelectedValue));
            }
            if (res == "ok")
            {
                MessageBox.Show("Se elimino con exito");
                txtDetalle.Text = "";
                llenarLista();
                limpiacajas();
            }
            else
            {
                MessageBox.Show($"Ocurrio un error {res}");
            }
        }
    }
}
