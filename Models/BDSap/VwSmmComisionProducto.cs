using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwSmmComisionProducto
{
    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? USubCategoria { get; set; }

    public decimal? PrcComision { get; set; }

    public string TipoComision { get; set; } = null!;

    public short? ItmsGrpCod { get; set; }

    public string? UMarcaProducto { get; set; }
}
