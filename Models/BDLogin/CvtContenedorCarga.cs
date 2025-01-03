using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtContenedorCarga
{
    public int IdContenedorCarga { get; set; }

    public short TipoContenedor { get; set; }

    public int NumPedido { get; set; }

    public short NumPedidoLinea { get; set; }

    public string CodProducto { get; set; } = null!;

    public decimal CantPedidoSap { get; set; }

    public decimal CantidadPallets { get; set; }

    public decimal CantidadProdBase { get; set; }

    public decimal CantidadProdAltura { get; set; }

    public string ObsIndUsoPallet { get; set; } = null!;

    public string ObsEntrega { get; set; } = null!;

    public short IndCargado { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;

    public decimal PesoTotalPallets { get; set; }

    public decimal VolTotalPallets { get; set; }

    public int IdContenedor { get; set; }
}
