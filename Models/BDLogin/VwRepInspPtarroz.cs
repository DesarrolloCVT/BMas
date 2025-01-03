using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwRepInspPtarroz
{
    public int Folio { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? Ano { get; set; }

    public int? Mes { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public int Linea { get; set; }

    public string? Lote { get; set; }

    public string? Proveedor { get; set; }

    public string CumpleColor { get; set; } = null!;

    public string CumpleMatExtrana { get; set; } = null!;

    public string CumpleGranosCascara { get; set; } = null!;

    public string CumplSemObjetables { get; set; } = null!;

    public string CumplGranosPartidos { get; set; } = null!;

    public string CumpleGranosYesoVerd { get; set; } = null!;

    public string CumpleGranManch { get; set; } = null!;

    public int? PorcCumplim { get; set; }
}
