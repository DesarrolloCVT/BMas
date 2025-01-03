using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwExpedicionFilmDetalleLote
{
    public int ExpFilmId { get; set; }

    public string? Producto { get; set; }

    public decimal? Cantidad { get; set; }

    public string? ExpFilmLote { get; set; }
}
