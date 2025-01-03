using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwRepInspvisualSaco
{
    public DateOnly? Fecha { get; set; }

    public int? Ano { get; set; }

    public int? Mes { get; set; }

    public TimeOnly Hora { get; set; }

    public string? Producto { get; set; }

    public string? LoteMp { get; set; }

    public string? Proveedor { get; set; }

    public decimal Humedad { get; set; }

    public string MatExtrAnimal { get; set; } = null!;

    public string MatExtranas { get; set; } = null!;

    public string? Cumplimiento { get; set; }
}
