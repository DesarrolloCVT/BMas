using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwTransferenciaCv410
{
    public int? Mes { get; set; }

    public int? Año { get; set; }

    public string? Defecto { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public string? CodProveedor { get; set; }

    public string? Proveedor { get; set; }

    public decimal? PesoBruto { get; set; }

    public decimal? PesoNeto { get; set; }
}
