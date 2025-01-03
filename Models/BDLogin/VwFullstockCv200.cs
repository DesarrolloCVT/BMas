using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwFullstockCv200
{
    public string? Bodega { get; set; }

    public string? CodCliente { get; set; }

    public string? ArticleProviderDescription { get; set; }

    public string? Familia { get; set; }

    public int? Cantidad { get; set; }

    public DateOnly? Fvencimiento { get; set; }

    public int? Ano { get; set; }

    public int? Mes { get; set; }

    public string Sociedad { get; set; } = null!;

    public decimal? PrecioPromedio { get; set; }

    public decimal? Valorizado { get; set; }
}
