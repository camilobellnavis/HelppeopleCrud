using HelppeopleCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelppeopleCrud.BLL.Service
{
    public interface IVacanteService
    {
        Task<bool> Insertar(Vacante modelo);
        Task<bool> Actualizar(Vacante modelo);
        Task<bool> Eliminar(int id);
        Task<Vacante> Obtener(int id);
        Task<IQueryable<Vacante>> ObtenerTodos();
    }
}
