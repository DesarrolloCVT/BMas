using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPreparaPedidoBodega
{
    public int NumPedidoSap { get; set; }

    public int NumPedidoWms { get; set; }

    public DateTime FechaDesp { get; set; }

    public string Cliente { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public string DescProducto { get; set; } = null!;

    public decimal CantidadPedido { get; set; }

    public decimal CantPalCompleto { get; set; }

    public decimal CantSaldoInicio { get; set; }

    public decimal CantSaldoxMerma { get; set; }

    public decimal? CantPicadillo { get; set; }

    public int? Completado { get; set; }
}
