using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alertas_Timer.Models
{
    public class AlertaModel
    {
        public int Id { get; set; }
        public string tipo { get; set; }
        public float valor { get; set; }
        public DateOnly fecha { get; set; }
        public TimeOnly hora { get; set; }
        public string mensaje { get; set; }
        public string estado { get; set; }
        public ServidorModel Servidores { get; set; }
        public ParametroModel Parametros { get; set; }
    }
}
