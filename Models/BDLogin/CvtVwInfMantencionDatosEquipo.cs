using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwInfMantencionDatosEquipo
{
    public string? UsuarioEquipo { get; set; }

    public string? Dispositivo { get; set; }

    public string? NombreEquipo { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Ram { get; set; }

    public string? Procesador { get; set; }

    public string? SistemaOperativo { get; set; }

    public string? CodAf { get; set; }

    public string Tipo { get; set; } = null!;
}
