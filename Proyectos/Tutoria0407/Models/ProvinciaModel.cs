using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria0407.Models
{
    internal class ProvinciaModel
    {
        public int Id { get; set; }
        public string Detalle { get; set; }
//relacion
        public PaisModel Paises { get; set; }
    }
}
