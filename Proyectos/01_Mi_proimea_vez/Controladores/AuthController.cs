namespace _01_Mi_proimea_vez.Controladores
{
    class AuthController
    {
        /*
         * Login   -  Inicio de Sesion           x
         * Estado de Usuario (True / Flase)
         * LogOut  -  Cerrar Sesion                x 
         * Cambio de Contrasenia
         */

        UsuariosController _usuariosController = new UsuariosController();

        public bool Login(string usuario, string contrasenia) {
            var usr = _usuariosController._listaUsuarios
                .Find(u => u.Nombre_Usuario == usuario && u.Contrasenia == contrasenia);
            if (usr != null)
            {
                Modelos.Session.UsuarioId = usr.UsuarioId;
                Modelos.Session.NombreUsuario = usr.Nombre + " " + usr.Apellido;
                Modelos.Session.estado = true;

                Program.UsuarioId = usr.UsuarioId;
                Program.NombreUsuario = usr.Nombre + " " + usr.Apellido;
                Program.estado = true;
                return true;
            }
            else {
                return false;
            }
            //return usr != null;
        }


        public void LogOut() {
            Modelos.Session.UsuarioId = 0;
            Modelos.Session.NombreUsuario = "";
            Modelos.Session.estado = false;

            Program.UsuarioId = 0;
            Program.NombreUsuario = "";
            Program.estado = false;
        }


        public bool ActualizarEstadoUsaurio(int UsuarioId) {
            var usr = _usuariosController._listaUsuarios
                .Find(u => u.UsuarioId == UsuarioId);
            if (usr != null) return false;
            if (usr.Estado == false)
            {
                usr.Estado = true;
                return true;
            }
            else {
                usr.Estado = false;
                return true;
            }
        }

        public bool ActualizarContaseniaUsaurio(int UsuarioId, string contrasenia)
        {
            var usr = _usuariosController._listaUsuarios
                .Find(u => u.UsuarioId == UsuarioId);
            if (usr != null) {
                usr.Contrasenia = contrasenia;
                return true;
            }
            else{ 
                return false;
            }
        }
    }
}
