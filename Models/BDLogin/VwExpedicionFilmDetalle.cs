using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwExpedicionFilmDetalle
{
    public int ExpFilmId { get; set; }

    public int? ExpFilmNumDocSap { get; set; }

    public string? ExpFilmNote { get; set; }

    public DateTime? ExpFilmDateIn { get; set; }

    public string? SiteShortDescription { get; set; }

    public string? Producto { get; set; }

    public string? CardCode { get; set; }

    public decimal? Cantidad { get; set; }
}
