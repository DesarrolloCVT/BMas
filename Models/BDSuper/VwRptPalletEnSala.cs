using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwRptPalletEnSala
{
    public string? CodProducto { get; set; }

    public string? DetProducto { get; set; }

    public int IdRegPallet { get; set; }

    public int? Cantidad { get; set; }

    public DateTime? FechaVenc { get; set; }
}
