﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Controllers
{
    class AuthController
    {
        private Models.LoginModel _loginModel = new Models.LoginModel();
       
        public string login(Models.LoginModel Usuario) {
            return _loginModel.VerificarLogin(Usuario);
        }

        public string login2(Models.LoginModel Usuario)
        {
            return _loginModel.VerificarLogin2(Usuario);
        }
        public void logOut() {
            Program.Nombreusuario = "";
            Program.Estado = 0;
            Program.UsuarioId = 0;
        }
    }
}
//public List<Models.LoginModel> _listaLoginModels = new List<Models.LoginModel>();
/* public AuthController()
        {
            var usuario = new Models.LoginModel
            {
                Contrasenia = "123",
                Correo = "coreo@gmail.com",
                Estado = true,
                Nombre = "Admin",
                NombreUsuario = "Admin",
                UsuarioId = 1
            };
            _listaLoginModels.Add(usuario);
        }*/
/*
 public List<Models.LoginModel> todos() {
     return _listaLoginModels;
 }

public Models.LoginModel uno(int id) {
     return _listaLoginModels.Find(u => u.UsuarioId == id);
 }

 public Models.LoginModel uno(string usuario) {
     return _listaLoginModels.Find(u => u.NombreUsuario == usuario);
 }
*/