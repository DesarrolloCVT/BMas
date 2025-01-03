using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwStockSmm
{
    public int? Bodega { get; set; }

    public string? Descripcion { get; set; }

    public int PackageId { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? CantidadInicial { get; set; }

    public string CodProducto { get; set; } = null!;

    public int Documento { get; set; }

    public DateOnly? Fproduccion { get; set; }

    public DateOnly? Fvencimiento { get; set; }

    public DateOnly? Frecepcion { get; set; }

    public string? Lote { get; set; }

    public int? Estado { get; set; }

    public int Nrecepcion { get; set; }

    public string? Npallet { get; set; }

    public string? DocType { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string? LayoutDescription { get; set; }
}
