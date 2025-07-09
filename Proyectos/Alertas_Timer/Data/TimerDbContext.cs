
using Alertas_Timer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Este archivo controla la base de datos
namespace  Alertas_Timer.DATA
{

    public class TimerDbContext : DbContext
    {
       
        public DbSet<ParametroModel> Parametros { get; set; }
        public DbSet<ServidorModel> Servidores { get; set; }


        public DbSet<AlertaModel> Alertas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexion = "server=localhost;database=Relaciones;pwd=root;uid=root";
            var version_mysql = new MySqlServerVersion(new Version("5.7.24"));
            optionsBuilder.UseMySql(conexion, version_mysql);
        }

       
    }
}
