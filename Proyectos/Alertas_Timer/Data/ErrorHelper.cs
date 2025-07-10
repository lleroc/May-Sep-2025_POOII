using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alertas_Timer.Data
{
    public static class ErrorHelper
    {
        ///<summary>
        /// Ejecuta una accion y muestra un MessageBox si ocurre un error
        /// </summary>
        /// <param name="accion"> Accion de ejecutar</param>
        /// <param name="mensajeUsuario"> Mensaje para mostrar al usuario si existe un error </param>
        public static void EjecutarMensaje(Action accion, string mensajeUsuario = "Ha ocurrido un error inesperado") {
            try
            {
                accion();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"{mensajeUsuario}\n \n Detalle: {ex.Message}", 
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                LogError(ex);
            }        
        }
        ///<summary>
        ///Guarda en un log de texto el error 
        /// </summary>
        public static void LogError(Exception ex) {
            string ruta = "log_errores.txt";
            string texto = $"[{DateTime.Now}] {ex.Message}\n";
            System.IO.File.AppendAllText(ruta, texto);
        }





    }
}
