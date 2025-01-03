using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmMaestroProductosCompleto
{
    public string Grupo { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Flejera { get; set; }

    public string? CodBarras { get; set; }

    public string? SkuProveedor { get; set; }

    public string? CodProveedor { get; set; }

    public string? NombreProveedor { get; set; }

    public string? Um { get; set; }

    public decimal? Upc { get; set; }

    public decimal? PrecioSala { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public decimal? Costo { get; set; }

    public decimal? CostoUnitario { get; set; }

    public string Impto { get; set; } = null!;

    public decimal? PorcImpuesto { get; set; }

    public decimal? CostoBruto { get; set; }

    public decimal? CostoBrutoUnitario { get; set; }

    public decimal? Margen { get; set; }

    public string? CodProductoHijo { get; set; }

    public string? DescripcionHijo { get; set; }

    public string? UmHijo { get; set; }

    public decimal? UpcHijo { get; set; }

    public decimal? PrecioHijo { get; set; }

    public decimal? PrecioUnitarioHijo { get; set; }

    public decimal? CostoHijo { get; set; }

    public decimal? CostoBrutoHijo { get; set; }

    public decimal? MargenHijo { get; set; }

    public string? CodProductoHijo1 { get; set; }

    public string? DescripcionHijo1 { get; set; }

    public string? UmHijo1 { get; set; }

    public decimal? UpcHijo1 { get; set; }

    public decimal? PrecioHijo1 { get; set; }

    public decimal? PrecioUnitarioHijo1 { get; set; }

    public decimal? CostoHijo1 { get; set; }

    public decimal? CostoBrutoHijo1 { get; set; }

    public decimal? MargenHijo1 { get; set; }
}
