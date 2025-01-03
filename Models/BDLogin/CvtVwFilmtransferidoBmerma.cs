using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwFilmtransferidoBmerma
{
    public int? Mes { get; set; }

    public int? Año { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public decimal? Quantity { get; set; }
}
