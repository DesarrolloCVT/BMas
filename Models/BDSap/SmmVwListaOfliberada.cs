using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmVwListaOfliberada
{
    public int Of { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }
}
