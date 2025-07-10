using Alertas_Timer.Controllers;
using Alertas_Timer.Data;
using Alertas_Timer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alertas_Timer.Views.Servidores
{
    public partial class frm_servidores : Form
    {
        private readonly ServidoresController _servidoresController;
        public frm_servidores()
        {
            InitializeComponent();
            _servidoresController = new ServidoresController();
        }

        private void chb_estado_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_estado.Checked == true)
            {
                chb_estado.Text = "Activo";
                chb_estado.BackColor = Color.Green;
            }
            else
            {
                chb_estado.Text = "Inactivo";
                chb_estado.BackColor = Color.Red;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ErrorHelper.EjecutarMensaje(() =>
            {
                ServidorModel servidorModel = new ServidorModel
                {
                    estado = chb_estado.Checked == true ? "Activo" : "Inactivo",
                    ip = txt_ip.Text,
                    nombre_servidor = txt_nombre.Text,
                    sistema_operativo = txt_sistema_operativo.Text,
                    ubicacion = txt_ubicacion.Text
                };
                if (_servidoresController.insertar(servidorModel) == "ok")
                {
                    MessageBox.Show("Se guado con exito",
                        "Gestion de Servidor"
                        , MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    cargaLista();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guardar",
                        "Gestion de Servidor"
                        , MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            });
        }

        private void frm_servidores_Load(object sender, EventArgs e)
        {
            cargaLista();
        }
        public void cargaLista() {
            listBox1.DataSource = _servidoresController.todos();
            listBox1.DisplayMember = "nombre_servidor";
            listBox1.ValueMember = "Id";
        
        }
    }
}
