using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmPreventaDetalle
{
    public int PreventaId { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public decimal? Cantidad { get; set; }

    public int? Precio { get; set; }

    public int? Descuento { get; set; }

    public decimal? Total { get; set; }

    public string? CodBarra { get; set; }

    public string UniMedida { get; set; } = null!;

    public int? CodUniMedida { get; set; }

    public int? ByOrder { get; set; }
}
