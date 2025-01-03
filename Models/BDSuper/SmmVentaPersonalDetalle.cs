using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVentaPersonalDetalle
{
    public int IdVenta { get; set; }

    public string CodProducto { get; set; } = null!;

    public string UniMedida { get; set; } = null!;

    public string? Producto { get; set; }

    public int? Cantidad { get; set; }

    public int? Precio { get; set; }

    public int? Total { get; set; }

    public string? CodBarra { get; set; }

    public int? CodUniMed { get; set; }

    public int? Descuento { get; set; }

    public int? ByOrder { get; set; }
}
