namespace Inventarios.Config
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using MySql.Data.MySqlClient;
   public class Conexion
    {
        //sqlconnecction    Sirve para abrir o cerar la conexion a la base de datos
        private readonly string cadenaConexionSqlServer =
            "server=(local);database=Cuarto_MaySep2025;uid=cuarto;pwd=123;Trusted_Connection=True";

        private readonly string cadenaConexionMySql =
            "server=localhost;database=Cuarto_MaySep2025;uid=root;pwd=root;";
        private SqlConnection conexion;
        private MySqlConnection conexionMySql;


        public IDbConnection AbrirConexion(int tipobase = 1) {

            if (tipobase == 1)
            {
                conexion = new SqlConnection(cadenaConexionSqlServer);
                conexion.Open();
                return conexion;
            }
            else {
                conexionMySql = new MySqlConnection(cadenaConexionMySql);
                conexion.Open();
                return conexion;
            }
               
        }

        public void CerrarConexion(int tipobase = 1) {
            if (tipobase == 1)
            {
                conexion.Close();
            }
            else {
                conexionMySql.Close();
            }
        }

    }
}
