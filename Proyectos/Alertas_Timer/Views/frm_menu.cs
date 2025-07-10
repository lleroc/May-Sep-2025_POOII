using Alertas_Timer.Views.Parametros;
using Alertas_Timer.Views.Servidores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alertas_Timer.Views
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void alertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_alerta = new Form1();
            frm_alerta.ShowDialog();
        }

        private void servidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_servidores frm_Servidores = new frm_servidores();
            frm_Servidores.ShowDialog();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_parametros frm_Parametros = new frm_parametros();
            frm_Parametros.ShowDialog();
        }
    }
}
