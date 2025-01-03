using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwRepInspPtlegunbre
{
    public int Folio { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? Ano { get; set; }

    public int? Mes { get; set; }

    public TimeOnly Hora { get; set; }

    public int Linea { get; set; }

    public string Producto { get; set; } = null!;

    public string Lote { get; set; } = null!;

    public string? Proveedor { get; set; }

    public string CumplGranDanados { get; set; } = null!;

    public string CumplGranManchados { get; set; } = null!;

    public string CumplColor { get; set; } = null!;

    public string CumplGranEnterosArrugados { get; set; } = null!;

    public string MateExtrana { get; set; } = null!;

    public int? PorcCumpli { get; set; }
}
