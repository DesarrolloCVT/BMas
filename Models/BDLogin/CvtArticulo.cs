using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtArticulo
{
    public int ArticuloId { get; set; }

    public string ArticuloCodigo { get; set; } = null!;

    public string ArticuloNombre { get; set; } = null!;

    public string AriticuloUbicacion { get; set; } = null!;

    public int ArticuloStock { get; set; }

    public int ArticuloStockMin { get; set; }

    public string? ArticuloProveedor { get; set; }

    public string? TipoArticulo { get; set; }
}
