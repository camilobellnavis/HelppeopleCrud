using HelppeopleCrud.Models;

namespace HelppeopleCrud.AplicacionWeb.DTO_s
{
    public class VacanteDTO
    {
        public int Id { get; set; }

        public string? Codigo { get; set; }

        public string? Cargo { get; set; }

        public string? Descripcion { get; set; }

        public string? Empresa { get; set; }

        public int? Salario { get; set; }

        public bool? Estado { get; set; }

        public int? IdCiudadano { get; set; }

        
    }
}
