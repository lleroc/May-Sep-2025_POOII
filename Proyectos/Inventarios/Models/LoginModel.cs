using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace Inventarios.Models
{
    public class LoginModel : UsuarioModel
    {
        //dataReader
        private Config.Conexion _conexion = new Config.Conexion();

        public string Error { get; set; }

        public string VerificarLogin(LoginModel loginModel) {
            try
            {
                using (IDbConnection con = _conexion.AbrirConexion(0))
                {
                    string cadena =
                        "SELECT * FROM Usuarios where " +
                        "NombreUsuario = @usuario and password = @contrasenia";
                    MySqlCommand sqlCommand = new MySqlCommand(cadena, (MySqlConnection)con);
                    sqlCommand.Parameters.AddWithValue("@usuario", loginModel.NombreUsuario);
                    sqlCommand.Parameters.AddWithValue("@contrasenia", loginModel.Contrasenia);

                    MySqlDataReader dr = sqlCommand.ExecuteReader();

                    if (dr.HasRows)
                    {
                        return "ok";
                    }
                    else {
                        Error = "El usuario o la contrasenia son incorrectos";
                        return Error;
                    }
                }
            }
            catch (Exception ex)
            {
                Error = "Error al intentar el login" + ex.Message;
                return Error;
            }
        }

              
    }
}
