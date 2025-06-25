using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace Inventarios.Models
{
    public class UsuarioModel
    {
        private Config.Conexion _conexion = new Config.Conexion();
       
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
      
        //es la relacion con la tabla roles
        public int RolesId { get; set; }
        public string Rol { get; set; } = null;

        public List<UsuarioModel> todos() {
            List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();
            using (IDbConnection cn = _conexion.AbrirConexion(0))
            {
                string cadena = "SELECT * FROM `usuarios` inner JOIN " +
                    "roles on usuarios.RolesId = roles.RolesId";
                using (MySqlCommand cmd = (MySqlCommand)cn.CreateCommand())
                {
                    cmd.CommandText = cadena;
                    using (IDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            UsuarioModel usuarioModel = new UsuarioModel {
                                password = lector[""].ToString(),
                                correo = lector[""].ToString(),
                                Rol = lector[""].ToString(),
                                Nombre = lector[""].ToString(),
                                RolesId = Convert.ToInt32(lector[""]),
                                UsuarioId = Convert.ToInt32(lector[""])
                            };
                            listaUsuarios.Add(usuarioModel);
                        }
                    }
                }
            }
            return listaUsuarios;
        
        }

    }
}
