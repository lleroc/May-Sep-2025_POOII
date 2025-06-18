using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Acceso_Datos;

namespace Capa_Aplicacion.Usuarios
{
    public class UsuarioService
    {
        private Capa_Acceso_Datos.Clases.ClaseUsuarios _claseUsuarios =
            new Capa_Acceso_Datos.Clases.ClaseUsuarios();
        public List<Capa_Datos.UsuarioDTO> todos()
        {
            return _claseUsuarios.todos();
        }
    }
}
