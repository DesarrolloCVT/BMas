using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwProductosRecepcionXamarin
{
    public string? CodProducto { get; set; }

    public string? Descripcion { get; set; }

    public int Norden { get; set; }

    public decimal? CantOrden { get; set; }

    public int? CodUm { get; set; }

    public string? NombreUm { get; set; }

    public string? CodProveedor { get; set; }

    public string? Proveedor { get; set; }

    public string CodBarra { get; set; } = null!;

    public DateOnly? Fecha { get; set; }

    public int? Precio { get; set; }
}
