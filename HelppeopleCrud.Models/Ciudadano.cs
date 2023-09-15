using System;
using System.Collections.Generic;

namespace HelppeopleCrud.Models;

public partial class Ciudadano
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

    public virtual ICollection<Vacante> Vacantes { get; set; } = new List<Vacante>();
}
