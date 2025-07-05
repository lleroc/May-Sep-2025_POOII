using EfCore_Code_Firts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Este archivo controla la base de datos
namespace EfCore_Code_Firts.DATA
{

    public class AppContext : DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexion = "server=localhost;database=EFCORE;pwd=root;uid=root";
            var version_mysql = new MySqlServerVersion(new Version("5.7.24"));
            optionsBuilder.UseMySql(conexion, version_mysql);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioModel>(
                (entidad) =>
                {
                    entidad.Property(p => p.Create_At)
                    .HasColumnType("TIMESTAMP")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
                    entidad.Property(p => p.Update_Up)
                    .HasColumnType("TIMESTAMP")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");
                });
        }
    }
}
