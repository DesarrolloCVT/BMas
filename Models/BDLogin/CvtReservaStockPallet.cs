using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtReservaStockPallet
{
    public int NumPedido { get; set; }

    public short NumPedidoLinea { get; set; }

    public string CodProducto { get; set; } = null!;

    public decimal CantPedidoSap { get; set; }

    public decimal CantidadReserva { get; set; }

    public string PackageSscc { get; set; } = null!;

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;
}
