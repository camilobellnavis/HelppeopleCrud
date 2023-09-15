using HelppeopleCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelppeopleCrud.BLL.Service
{
    public interface ICiudadanoService
    {
        Task<bool> Insertar(Ciudadano modelo);
        Task<bool> Actualizar(Ciudadano modelo);
        Task<bool> Eliminar(int id);
        Task<Ciudadano> Obtener(int id);
        Task<IQueryable<Ciudadano>> ObtenerTodos();
    }
}
