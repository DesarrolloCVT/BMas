using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmVwListaPrecioFlejera
{
    public string Categoria { get; set; } = null!;

    public string CodSubCategoria { get; set; } = null!;

    public string SubCategoria { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public decimal? PrecioUnitarioCaja { get; set; }

    public decimal? PrecioCaja { get; set; }

    public string? UnidadMedida { get; set; }

    public string? CodigoBarra { get; set; }

    public decimal? Upc { get; set; }
}
