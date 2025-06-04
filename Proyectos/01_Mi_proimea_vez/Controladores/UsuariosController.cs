using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mi_proimea_vez.Controladores
{
    class UsuariosController
    {
        Modelos.Usuarios _usuarioModel = new Modelos.Usuarios();

        List<Modelos.Usuarios> _listaUsuarios = new List<Modelos.Usuarios>();

        public UsuariosController()
        {

        }

        public List<Modelos.Usuarios> todos() {
            return _listaUsuarios;
        }
        public Modelos.Usuarios uno(int UsuarioId) {

            return _listaUsuarios.Find(usuarios => usuarios.UsuarioId == UsuarioId);
        }
        public string insrtar(Modelos.Usuarios usuarioModel)
        {
            try
            {
                _listaUsuarios.Add(usuarioModel);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

    }
}
