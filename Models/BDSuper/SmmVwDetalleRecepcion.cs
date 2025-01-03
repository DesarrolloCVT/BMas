using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwDetalleRecepcion
{
    public int? ReceptionId { get; set; }

    public string ItemCode { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public string CardCode { get; set; } = null!;

    public int ReceptionDocNumber { get; set; }

    public string? ReceptionNote { get; set; }

    public string? SiteDescription { get; set; }

    public int? NumDocSap { get; set; }

    public int? TipoDocSap { get; set; }

    public int? UomEntry { get; set; }
}
