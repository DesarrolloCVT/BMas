using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwTrazabilidadBultosConReserva
{
    public string? Npallet { get; set; }

    public string Operacion { get; set; } = null!;

    public int TransferId { get; set; }

    public string Estado { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public decimal? PackageReserveQuantity { get; set; }

    public DateTime Fecha { get; set; }
}
