﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using WindowsFormsCRUD.Datos;

namespace WindowsFormsCRUD.AccesoDatos
{
   public  class ClaseUsuarios
    {
        private Conexion _conexion = new Conexion();

        public List<UsuarioDTO> todos() {
            //todos los pocedimientos necesario para conectarme a la
            //base de datos y devolver todos los usuarios
            var listaUsuario = new List<UsuarioDTO>();
            using (SqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "SELECT UsuarioId, Nombre, NombreUsuario, Contrasenia, Correo, Estado " +
                    "FROM Usuarios WHERE  (Estado = 1)";
                using (SqlCommand cmd = new SqlCommand(cadena, cn))
                {
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            UsuarioDTO usuarioDTO = new UsuarioDTO
                            {
                                UsuarioId = lector.GetInt32(0),
                                Nombre = lector.GetString(1),
                                NombreUsuario = lector.GetString(2),
                                Contrasenia = lector.GetString(3),
                                Correo = lector.GetString(4),
                                Estado = lector.GetBoolean(5)
                            };
                            listaUsuario.Add(usuarioDTO);
                        }
                    }
                }
            }
            return listaUsuario;
        }
    }
}
