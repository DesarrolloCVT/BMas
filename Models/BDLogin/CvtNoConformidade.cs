using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtNoConformidade
{
    public int IdNoConformidad { get; set; }

    public int IdAreaNoConformidad { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string Estado { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string? Observaciones { get; set; }

    public int? Version { get; set; }

    public DateTime? FechaUltimaMod { get; set; }

    public string? UsuarioultimaMod { get; set; }
}
