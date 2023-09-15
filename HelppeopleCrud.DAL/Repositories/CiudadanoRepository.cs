using HelppeopleCrud.DAL.DataContext;
using HelppeopleCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelppeopleCrud.DAL.Repositories
{
    public class CiudadanoRepository : IGenericRepository<Ciudadano>
    {
        private readonly HpeopleContext _helppeopleContext;
        public CiudadanoRepository(HpeopleContext context)
        {
            _helppeopleContext= context;
        }
        public async Task<bool> Actualizar(Ciudadano modelo)
        {
            _helppeopleContext.Ciudadanos.Update(modelo);
            await _helppeopleContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Ciudadano modelo = _helppeopleContext.Ciudadanos.First(c => c.Id == id);
            _helppeopleContext.Ciudadanos.Remove(modelo);
            await _helppeopleContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Ciudadano modelo)
        {
            _helppeopleContext.Ciudadanos.Add(modelo);
            await _helppeopleContext.SaveChangesAsync();
            return true;
        }

        public async Task<Ciudadano> Obtener(int id)
        {
            return await _helppeopleContext.Ciudadanos.FindAsync(id);
        }

        public async Task<IQueryable<Ciudadano>> ObtenerTodos()
        {
            IQueryable<Ciudadano> query = _helppeopleContext.Ciudadanos;
            return query;
        }
    }
}
