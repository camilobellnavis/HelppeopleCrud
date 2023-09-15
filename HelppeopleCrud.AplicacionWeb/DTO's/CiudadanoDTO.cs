using HelppeopleCrud.Models;

namespace HelppeopleCrud.AplicacionWeb.DTO_s
{
    public class CiudadanoDTO
    {
        public int Id { get; set; }

        public string? Nombres { get; set; }

        public string? Apellidos { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public string? Profesion { get; set; }

        public int? Aspiracion { get; set; }

        public string? Email { get; set; }

        public string? NumeroDoc { get; set; }

        public string? TipoDoc { get; set; }

    }
}
