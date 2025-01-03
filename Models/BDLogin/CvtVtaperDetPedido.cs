using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVtaperDetPedido
{
    public int IdCabPedido { get; set; }

    public string CodProducto { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public int? IdUsuario { get; set; }

    public string? Equipo { get; set; }

    public string? EqUsuario { get; set; }

    public string? IpAddress { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaUpdate { get; set; }
}
