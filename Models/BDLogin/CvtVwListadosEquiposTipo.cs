using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwListadosEquiposTipo
{
    public int Tipo { get; set; }

    public int Id { get; set; }

    public string? CodAf { get; set; }

    public string? Modelo { get; set; }

    public string Marca { get; set; } = null!;

    public string? Equipo { get; set; }

    public string? Codigo { get; set; }
}
