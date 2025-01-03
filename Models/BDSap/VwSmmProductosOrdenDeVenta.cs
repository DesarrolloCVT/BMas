using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwSmmProductosOrdenDeVenta
{
    public string Codproducto { get; set; } = null!;

    public string? Producto { get; set; }

    public short? Familia { get; set; }

    public int? UnxCaja { get; set; }

    public int? CostoPromedio { get; set; }

    public int? UltimoPrecioCompra { get; set; }

    public int? Precio { get; set; }

    public decimal? Margen { get; set; }

    public int? Contribucion { get; set; }

    public decimal? Stock { get; set; }
}
