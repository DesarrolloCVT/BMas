using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtReservaStockPedidoUbicacion
{
    public int NumPedido { get; set; }

    public int LayoutWms { get; set; }

    public short IndFaltaSaldo { get; set; }

    public string ObsLugarFisico { get; set; } = null!;

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;
}
