using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtStock
{
    public string? Codigo { get; set; }

    public string? Proveedor { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Stock { get; set; }

    public decimal? CostoProm { get; set; }

    public decimal? CostoUltCompra { get; set; }

    public decimal? SolicitadoVentas { get; set; }

    public decimal? ComprometidoVentas { get; set; }
}
