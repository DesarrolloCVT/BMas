using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwResumenReclamoCab
{
    public int IdReclamo { get; set; }

    public string? CodProducto { get; set; }

    public int? Cantidad { get; set; }
}
