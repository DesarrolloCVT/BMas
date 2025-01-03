using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlEnvasadoPt
{
    public int IdControlEnvPt { get; set; }

    public int? Operador { get; set; }

    public int? Of { get; set; }

    public int? Turno { get; set; }

    public int? Sala { get; set; }

    public string? Linea { get; set; }

    public TimeOnly? HoraInicio { get; set; }

    public TimeOnly? HoraTermino { get; set; }

    public int? Abocador { get; set; }

    public string? Origen1 { get; set; }

    public string? Origen2 { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? LoteMp { get; set; }

    public string? Marca { get; set; }

    public int? TotalSaldo { get; set; }

    public int? TotalPallet { get; set; }

    public int? TotalMerma { get; set; }

    public string? MateriaPrima { get; set; }

    public int? Estado { get; set; }

    public DateTime? FechaValidacion { get; set; }

    public int? UsuarioValidador { get; set; }
}
