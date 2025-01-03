using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTblConsumoOf
{
    public int ItemOf { get; set; }

    public int? NroOf { get; set; }

    public string? CodigoProducto { get; set; }

    public string? Descripcion { get; set; }

    public string? CodigoLote { get; set; }

    public double? Cantidad { get; set; }

    public string? TipoProducto { get; set; }

    public string? Motivo { get; set; }

    public string? CodigoProducto2 { get; set; }

    public double? Cantidad2 { get; set; }

    public string? Estado { get; set; }

    public int? Line { get; set; }

    public string? Bodega { get; set; }
}
