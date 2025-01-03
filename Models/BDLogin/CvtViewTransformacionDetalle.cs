using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtViewTransformacionDetalle
{
    public int TransformacionDetId { get; set; }

    public string? Npallet { get; set; }

    public string? Codigo { get; set; }

    public string? Producto { get; set; }

    public int Cantidad { get; set; }

    public string? NpalletDestino { get; set; }

    public string? CodigoDestino { get; set; }

    public string? ProductoDestino { get; set; }

    public int? CantidadDestino { get; set; }

    public string? Posicion { get; set; }

    public int TransformacionId { get; set; }

    public int PackageId { get; set; }

    public int ArticleProviderId { get; set; }

    public int? PackageDestinyId { get; set; }

    public int? ArticleProviderDestinyId { get; set; }

    public int? LayoutId { get; set; }

    public string? PackageLot { get; set; }
}
