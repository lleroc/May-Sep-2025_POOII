﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class UsuarioDTO
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }

    }
}
