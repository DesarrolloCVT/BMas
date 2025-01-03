using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtContenedorCargaDet
{
    public int IdContenedorCarga { get; set; }

    public short IdContCargaDet { get; set; }

    public int NumPedido { get; set; }

    public short NumPedidoLinea { get; set; }

    public string CodProducto { get; set; } = null!;

    public decimal CantPedidoSap { get; set; }

    public decimal Cantidad { get; set; }

    public short OrdenPalletizado { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;

    public decimal PesoTotalPallets { get; set; }

    public decimal VolTotalPallets { get; set; }

    /// <summary>
    /// Indica si producto está confirmado o dentro del pallet
    /// </summary>
    public bool EstadoCarga { get; set; }
}
