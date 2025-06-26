using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaciones.Model
{
   public class ProvinciaModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int id_pais { get; set; }

        public static implicit operator List<object>(ProvinciaModel v)
        {
            throw new NotImplementedException();
        }
    }
}
