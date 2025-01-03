using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwDatosOcXamarin
{
    public int DocEntry { get; set; }

    public int DocNum { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Proveedor { get; set; }

    public string? NomProveedor { get; set; }

    public string? ItemCode { get; set; }

    public string? Dscription { get; set; }

    public decimal? Quantity { get; set; }

    public string? CodeBars { get; set; }

    public string? DocStatus { get; set; }

    public string? Skuproveedor { get; set; }

    public int? Price { get; set; }
}
