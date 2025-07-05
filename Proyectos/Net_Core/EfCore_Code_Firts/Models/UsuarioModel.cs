using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Anotaciones de Datos
using System.ComponentModel.DataAnnotations;


namespace EfCore_Code_Firts.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo Nombre de usuario es requerido")]
        [MaxLength(50, ErrorMessage ="El maximo de caracteres es 50")]
        [MinLength(4,ErrorMessage = "El minimo de caracteres es 4")]
        public string Nombre_Usuario { get; set; }
        [Required]
        [Length(4,50,ErrorMessage ="Los caracteres permitidos son de 4 a 50")]
        public string Apellido_Usuario { get; set; }
        [Required]
        public string Rol_Usuario { get; set; }
        [Required]
        
        public string Contrasenia { get; set; }
        public DateTime Create_At { get; set; }
        public DateTime Update_Up { get; set; }
    }
}
