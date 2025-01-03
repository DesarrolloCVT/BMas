using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwRepInspPtazucar
{
    public int Folio { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? Ano { get; set; }

    public int? Mes { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public int Linea { get; set; }

    public string? Lote { get; set; }

    public string? Proveedor { get; set; }

    public string Impuresas { get; set; } = null!;

    public string MatExtraAnim { get; set; } = null!;

    public string MateriaExtrana { get; set; } = null!;

    public int? PorcCumpli { get; set; }
}
