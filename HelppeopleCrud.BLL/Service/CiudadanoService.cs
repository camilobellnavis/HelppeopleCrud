using HelppeopleCrud.DAL.Repositories;
using HelppeopleCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelppeopleCrud.BLL.Service
{
    public class CiudadanoService : ICiudadanoService
    {
        private readonly IGenericRepository<Ciudadano> _ciudadanoRepo;
        public CiudadanoService(IGenericRepository<Ciudadano> ciudadanoRepo)
        {
            _ciudadanoRepo= ciudadanoRepo;
        }
        public async Task<bool> Actualizar(Ciudadano modelo)
        {
            return await _ciudadanoRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _ciudadanoRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Ciudadano modelo)
        {
            return await _ciudadanoRepo.Insertar(modelo);
        }

        public async Task<Ciudadano> Obtener(int id)
        {
            return await _ciudadanoRepo.Obtener(id);
        }

        public async Task<IQueryable<Ciudadano>> ObtenerTodos()
        {
            return await _ciudadanoRepo.ObtenerTodos();
        }
    }
}
