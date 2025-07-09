using Alertas_Timer.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alertas_Timer.Controllers
{
    public class ServidoresController
    {
        private readonly TimerDbContext _timerDbContext;
        public ServidoresController() { 
            _timerDbContext = new TimerDbContext();
        }

        
    }
}
