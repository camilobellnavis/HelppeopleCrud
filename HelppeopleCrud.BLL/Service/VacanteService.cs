using HelppeopleCrud.DAL.Repositories;
using HelppeopleCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelppeopleCrud.BLL.Service
{
    public class VacanteService: IVacanteService
    {
        private readonly IGenericRepository<Vacante> _vacanteRepo;
        public VacanteService(IGenericRepository<Vacante> vacanteRepo)
        {
            _vacanteRepo = vacanteRepo;
        }
        public async Task<bool> Actualizar(Vacante modelo)
        {
            return await _vacanteRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _vacanteRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Vacante modelo)
        {
            return await _vacanteRepo.Insertar(modelo);
        }

        public async Task<Vacante> Obtener(int id)
        {
            return await _vacanteRepo.Obtener(id);
        }

        public async Task<IQueryable<Vacante>> ObtenerTodos()
        {
            return await _vacanteRepo.ObtenerTodos();
        }

    }
}

