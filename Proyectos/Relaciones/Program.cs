using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relaciones
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var frmProvincia = new View.Provincias.FRMProvincias();
            var presenteer = new Presenter.ProvinciaPresenter(frmProvincia);

           
            Application.Run(frmProvincia);
        }
    }
}
