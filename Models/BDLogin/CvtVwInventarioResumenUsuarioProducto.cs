using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwInventarioResumenUsuarioProducto
{
    public int InventarioId { get; set; }

    public string? Usuario { get; set; }

    public string CodProducto { get; set; } = null!;

    public int? CantidadPallets { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? Cantidad { get; set; }
}
