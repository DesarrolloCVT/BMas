using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVtaperCabPedido
{
    public int IdCabPedido { get; set; }

    public int SlpCode { get; set; }

    public string CodPeriodo { get; set; } = null!;

    public string CodBodega { get; set; } = null!;

    public string Comentarios { get; set; } = null!;

    public short Estado { get; set; }

    public int? IdUsuario { get; set; }

    public string? Equipo { get; set; }

    public string? EqUsuario { get; set; }

    public string? IpAddress { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaUpdate { get; set; }
}
