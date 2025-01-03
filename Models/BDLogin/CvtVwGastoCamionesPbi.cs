using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwGastoCamionesPbi
{
    public string Patente { get; set; } = null!;

    public string Propietario { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public string? Cuenta { get; set; }

    public string? DetalleGasto { get; set; }

    public string? Item { get; set; }

    public int? Monto { get; set; }

    public DateOnly Fecha { get; set; }

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public string? Nrendicion { get; set; }

    public int? CapacidadPallet { get; set; }
}
