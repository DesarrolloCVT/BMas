using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwDuplicadosInventario
{
    public int InventarioId { get; set; }

    public int? Cantidad { get; set; }

    public string? Dun14 { get; set; }
}
