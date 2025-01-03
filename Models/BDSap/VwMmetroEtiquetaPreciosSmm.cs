using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwMmetroEtiquetaPreciosSmm
{
    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public string? NombreUnidadPadre { get; set; }

    public decimal? UnidadPadreInformativo { get; set; }

    public string? UInfoAdicional { get; set; }

    public string? Dun14 { get; set; }

    public short? ItmsGrpCod { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public decimal? PrecioPadre { get; set; }

    public decimal? PrecioHijo { get; set; }

    public decimal? PrecioUnitarioHijo { get; set; }

    public string? CodHijo { get; set; }

    public string? Ean13 { get; set; }

    public string? ProductoHijo { get; set; }

    public decimal? CantidadHijos { get; set; }

    public string? NombreUnidadHijo { get; set; }

    public decimal? UnidadHijoInformativo { get; set; }
}
