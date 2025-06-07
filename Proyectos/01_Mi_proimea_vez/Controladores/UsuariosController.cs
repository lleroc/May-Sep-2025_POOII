using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mi_proimea_vez.Controladores
{
    class UsuariosController
    {
        public List<Modelos.Usuarios> _listaUsuarios = new List<Modelos.Usuarios>();
        public List<Modelos.Usuarios> todos() {
            return _listaUsuarios;
        }
        public Modelos.Usuarios uno(int UsuarioId) {
            return _listaUsuarios.Find(usuarios => usuarios.UsuarioId == UsuarioId);
        }
        public string insertar(Modelos.Usuarios nuevoUsuario)
        {
            try
            {
                _listaUsuarios.Add(nuevoUsuario);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string actualizar(Modelos.Usuarios actualizarUsuario)
        {
            try
            {
                var usr = _listaUsuarios.Find(usuarios => usuarios.UsuarioId == actualizarUsuario.UsuarioId);

                if (usr != null)
                {
                    usr.Nombre = actualizarUsuario.Nombre;
                    usr.Apellido = actualizarUsuario.Apellido;
                    usr.Contrasenia = actualizarUsuario.Contrasenia;
                    usr.correo = actualizarUsuario.correo;
                    usr.Nombre_Usuario = actualizarUsuario.Nombre_Usuario;
                    return "ok";
                }
                else {
                    return "Usuario no encontrado";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string eliminar(int usuarioId) {
            try
            {
                /*var usr2 = _listaUsuarios.RemoveAll(uuid => uuid.UsuarioId == usuarioId);
                if (usr2 > 0)
                {
                    return "ok";
                }
                else
                {
                    return "No se encontro el usuario";
                }*/
                
                var usr = _listaUsuarios.Find(uid => uid.UsuarioId == usuarioId);
                if (usr != null)
                {
                    _listaUsuarios.Remove(usr);
                    return "ok";
                }
                else {
                    return "Usuario no encontrado";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}//CRUD
//SOLID
/*
  Los Principios SOLID:
1 Principio de Responsabilidad Única (S): Cada clase debe tener una única responsabilidad. 
2 Principio Abierto/Cerrado (O): Las entidades de software (clases, módulos, funciones, etc.) 
deben estar abiertas para la extensión pero cerradas para la modificación. 
3 Principio de Sustitución de Liskov (L): Los subtipos deben ser capaces de sustituir a sus 
tipos base sin alterar la corrección del programa. 
4 Principio de Segregación de Interfaces (I): No se deben forzar a las entidades a depender 
de interfaces que no usan. 
5 Principio de Inversión de Dependencia (D): Las entidades de alto nivel no deben depender 
de las de bajo nivel; ambas deben depender de abstracciones. 
 
 */