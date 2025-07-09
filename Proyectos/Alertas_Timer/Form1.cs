using Alertas_Timer.Controllers;

namespace Alertas_Timer
{
    public partial class Form1 : Form
    {
        private readonly AlertaController _alertaController;
        public Form1()
        {
            InitializeComponent();
            _alertaController = new AlertaController(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dgvListaAllertas.DataSource = _alertaController.todos();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Interval = 5000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
