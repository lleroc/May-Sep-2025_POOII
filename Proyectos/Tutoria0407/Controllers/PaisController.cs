using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutoria0407.Data;
using Tutoria0407.Models;

namespace Tutoria0407.Controllers
{
    internal class PaisController
    {
        private readonly TutoriaDbContext _dbContext;
        public PaisController() {
            _dbContext = new TutoriaDbContext();
        }

        public List<PaisModel> todos() {
            return _dbContext.Paises.ToList();
        }
        public PaisModel uno(int PaisId) {
            return _dbContext.Paises.Find(PaisId);
        }
        public string insertar(PaisModel paisModel) {
            try
            {
                _dbContext.Paises.Add(paisModel);
                _dbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return  ex.ToString();
            }
        }
        public string actualizar(PaisModel paisModel) { 
            var pais = _dbContext.Paises.Find(paisModel.Id);
            if (pais != null)
            {
                pais.Detalle = paisModel.Detalle;
                _dbContext.SaveChanges();
                return "ok";
            }
            else {
                return "error";
            }
        }
        public string eliminar(int PaisId) {
            var pais = _dbContext.Paises.Find(PaisId);
            if (pais != null)
            {
                _dbContext.Remove(pais);
                _dbContext.SaveChanges();
                return "ok";
            }
            else {
                return "error";
            }
        }
    }
}
