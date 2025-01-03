using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroCompraUrea
{
    public int IdRegUrea { get; set; }

    public int? FolioFactura { get; set; }

    public DateTime? FechaFactura { get; set; }

    public decimal? LitrosComprados { get; set; }

    public int? PrecioLitro { get; set; }

    public decimal? Total { get; set; }
}
