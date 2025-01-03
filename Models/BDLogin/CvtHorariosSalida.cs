using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtHorariosSalida
{
    public short IdCfgHorarios { get; set; }

    public string DescHorario { get; set; } = null!;

    public string HorarioMin { get; set; } = null!;

    public string HorarioMax { get; set; } = null!;

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;
}
