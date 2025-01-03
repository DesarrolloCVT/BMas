using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmRegPalletSala
{
    public int IdRegPallet { get; set; }

    public string? CodProducto { get; set; }

    public string? DetProducto { get; set; }

    public int? Cantidad { get; set; }

    public DateTime? FechaVenc { get; set; }

    public int? Estado { get; set; }
}
