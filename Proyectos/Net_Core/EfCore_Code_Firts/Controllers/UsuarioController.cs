using EfCore_Code_Firts.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Code_Firts.Controllers
{
    public class UsuarioController
    {
        private readonly DATA.AppContext _appContext;
        public UsuarioController()
        {
            _appContext = new DATA.AppContext();
        }
        public string Insertar(UsuarioModel usuarioModel)
        {
            try
            {
                usuarioModel.Create_At = DateTime.Now;
                usuarioModel.Update_Up = DateTime.Now;
                _appContext.Add(usuarioModel);
                _appContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string actualizar(UsuarioModel usuarioModel)
        {
            var existe = _appContext.Usuarios.Find(usuarioModel.Id);
            if (existe != null)
            {
                try
                {
                    existe.Nombre_Usuario = usuarioModel.Nombre_Usuario;
                    existe.Apellido_Usuario = usuarioModel.Apellido_Usuario;
                    existe.Rol_Usuario = usuarioModel.Rol_Usuario;
                    existe.Contrasenia = usuarioModel.Contrasenia;
                    existe.Update_Up = DateTime.Now;
                    _appContext.SaveChanges();
                    return "ok";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else { return "El usuario no existe"; }
        }

        public string Eliminar(int UsuarioID)
        {
            try
            {
                var existe = _appContext.Usuarios.Find(UsuarioID);
                if (existe != null)
                {
                    _appContext.Remove(existe);
                    _appContext.SaveChanges();
                    return "ok";
                }
                else
                {
                    return "El usuario no existe";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<UsuarioModel> todos() {
            return _appContext.Usuarios.ToList();
        }
        public UsuarioModel uno(int id) {
            
            var existe = _appContext.Usuarios.Find(id);
            if (existe != null)
            {
                return existe;
            }
            else {
                return new UsuarioModel();
            }
        }
    }
}
