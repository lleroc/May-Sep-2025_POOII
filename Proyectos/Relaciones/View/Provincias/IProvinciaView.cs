using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaciones.View.Provincias
{
    public interface IProvinciaView
    {
        string nombre { get; }
        int id_provincia { get; }
        int id_pais { get; }

        void TodosProvincias(List<Model.ProvinciaModel> provincias);
   
        void LimpiarFormulario();
        void MostrarMensajes(string Mensaje);
        void TodosPaises(List<Model.PaisModel> paises);

        event EventHandler GuardarClicked;
        event EventHandler EliminarClicked;
        event EventHandler EditarCliked;
        event EventHandler SeleccionarProvincia;
        

    }
}
