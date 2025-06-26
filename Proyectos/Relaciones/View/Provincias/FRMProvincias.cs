using Relaciones.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relaciones.View.Provincias
{
    public partial class FRMProvincias : Form, IProvinciaView
    {
        private List<Model.ProvinciaModel> _provinciaModels;

        public FRMProvincias()
        {
            InitializeComponent();
            btnGuardar.Click += (s, e) => GuardarClicked?.Invoke(this, EventArgs.Empty);
            btnEditar.Click += (s, e) => EditarCliked?.Invoke(this, EventArgs.Empty);
            btnEliminar.Click += (s, e) => EliminarClicked?.Invoke(this, EventArgs.Empty);
            lstProvincias.SelectedIndexChanged += (s, e) => SeleccionarProvincia?.Invoke(this, EventArgs.Empty);
            
        }

        public string nombre => txtNombre.Text.Trim();
        public int id_pais => cmbPais.SelectedValue != null ? (int)cmbPais.SelectedValue : 0;

        public int id_provincia {
            get
            {
                if (lstProvincias.SelectedItem is Model.ProvinciaModel provincia)
                {
                    return provincia.id;
                }
                else {
                    return 0;
                }
            }
        
        }


        public event EventHandler GuardarClicked;
        public event EventHandler EliminarClicked;
        public event EventHandler EditarCliked;
        public event EventHandler SeleccionarProvincia;

        public void LimpiarFormulario()
        {
            txtNombre.Text = "";
            lstProvincias.ClearSelected();

        }

        public void MostrarMensajes(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }

        public void TodosPaises(List<PaisModel> paises)
        {
            cmbPais.DataSource = null;
            cmbPais.DataSource = paises;
            cmbPais.ValueMember = "id";
            cmbPais.DisplayMember = "nommbre";
        }

        public void TodosProvincias(List<ProvinciaModel> provincias)
        {
            _provinciaModels = provincias;
            lstProvincias.DataSource = null;
            lstProvincias.DataSource = _provinciaModels;
            lstProvincias.DisplayMember = "nombre";
            lstProvincias.ValueMember = "id";
        }

        private void FRMProvincias_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
