using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsCRUD.Aplicacion
{
    public class UsuarioService
    {
        private AccesoDatos.ClaseUsuarios _claseUsuarios =
            new AccesoDatos.ClaseUsuarios();
        public List<Datos.UsuarioDTO> todos()
        {
            return _claseUsuarios.todos();
        }
    }
}
