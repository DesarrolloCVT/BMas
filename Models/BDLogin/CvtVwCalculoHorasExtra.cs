using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwCalculoHorasExtra
{
    public string EmpleadoId { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public short He100 { get; set; }

    public int? Minutos { get; set; }

    public string Run { get; set; } = null!;

    public string? Nombre { get; set; }

    public string Departamento { get; set; } = null!;

    public decimal? ValorBruto { get; set; }

    public decimal? ValorRedondeado { get; set; }

    public int SueldoBase { get; set; }

    public decimal? Horas { get; set; }

    public int? Semana { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public int? Dia { get; set; }

    public int? _20000 { get; set; }

    public int? _10000 { get; set; }

    public int? _5000 { get; set; }

    public int? _1000 { get; set; }
}
