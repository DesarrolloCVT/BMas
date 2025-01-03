using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwReporControlEnvasadoptCab
{
    public int IdControlEnvPt { get; set; }

    public string Operador { get; set; } = null!;

    public string? Abocador { get; set; }

    public int? Of { get; set; }

    public string? Producto { get; set; }

    public int? Turno { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Sala { get; set; }

    public string? Linea { get; set; }

    public TimeOnly? HoraInicio { get; set; }

    public TimeOnly? HoraTermino { get; set; }

    public int? ProductoEnvasados { get; set; }

    public decimal? KilosEnvasados { get; set; }

    public string LotePt { get; set; } = null!;

    public string Origen { get; set; } = null!;

    public int? Barrido { get; set; }

    public string? LoteMp { get; set; }

    public string? Marca { get; set; }

    public int? TotalSaldo { get; set; }

    public int? TotalMerma { get; set; }

    public int? TotalPallet { get; set; }

    public string? MateriaPrima { get; set; }
}
