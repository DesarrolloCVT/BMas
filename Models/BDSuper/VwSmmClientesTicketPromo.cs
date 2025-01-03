using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwSmmClientesTicketPromo
{
    public int PreventaId { get; set; }

    public string? CodigoCliente { get; set; }

    public int? TotalVent { get; set; }

    public string CodProducto { get; set; } = null!;
}
