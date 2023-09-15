using HelppeopleCrud.DAL.DataContext;
using HelppeopleCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelppeopleCrud.DAL.Repositories
{
    public class VacanteRepository : IGenericRepository<Vacante>
    {
        private readonly HpeopleContext _helppeopleContext;
        public VacanteRepository(HpeopleContext context)
        {
            _helppeopleContext = context;
        }
        public async Task<bool> Actualizar(Vacante modelo)
        {
            _helppeopleContext.Vacantes.Update(modelo);
            await _helppeopleContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Vacante modelo = _helppeopleContext.Vacantes.First(c => c.Id == id);
            _helppeopleContext.Vacantes.Remove(modelo);
            await _helppeopleContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Vacante modelo)
        {
            _helppeopleContext.Vacantes.Add(modelo);
            await _helppeopleContext.SaveChangesAsync();
            return true;
        }

        public async Task<Vacante> Obtener(int id)
        {
            return await _helppeopleContext.Vacantes.FindAsync(id);
        }

        public async Task<IQueryable<Vacante>> ObtenerTodos()
        {
            IQueryable<Vacante> query = _helppeopleContext.Vacantes;
            return query;
        }
    }
}
