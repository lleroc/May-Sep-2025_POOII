using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Login.Models
{
    public class LoginModel : UsuarioModel
    {
        //dataReader
        private Config.Conexion _conexion = new Config.Conexion();

        public string Error { get; set; }

        public string VerificarLogin(LoginModel loginModel) {
            try
            {
                using (SqlConnection con = _conexion.AbrirConexion())
                {
                    string cadena =
                        "SELECT * FROM Usuarios where " +
                        "NombreUsuario = @usuario and Contrasenia = @contrasenia";
                    SqlCommand sqlCommand = new SqlCommand(cadena, con);
                    sqlCommand.Parameters.AddWithValue("@usuario", loginModel.NombreUsuario);
                    sqlCommand.Parameters.AddWithValue("@contrasenia", loginModel.Contrasenia);

                    SqlDataReader dr = sqlCommand.ExecuteReader();

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

        public string VerificarLogin2(LoginModel loginModel)
        {
            try
            {
                SqlConnection con = _conexion.AbrirConexion();
                string cadena =
                        "SELECT * FROM Usuarios where " +
                        "NombreUsuario = '" + loginModel.NombreUsuario + "' " +
                        "and Contrasenia = '" + loginModel.Contrasenia + "'";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return "ok";
                }
                else
                {
                    Error = "El usuario o la contrasenia son incorrectos";
                    return Error;
                }
            }
            catch (Exception ex)
            {
                Error = "Error al intentar el login" + ex.Message;
                return Error;
            }
            finally {
                _conexion.CerrarConexion();
            }
        }
    }
}
