using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwFiltroDetProdBloqueado
{
    public int PackageId { get; set; }

    public int? LayoutId { get; set; }

    public string? CodProducto { get; set; }

    public string? DescProducto { get; set; }

    public string? NumPallet { get; set; }

    public int SiteId { get; set; }

    public string? Ubicacion { get; set; }

    public string? Bodega { get; set; }

    public string? Lote { get; set; }

    public int Cantidad { get; set; }

    public int? NumRecepcion { get; set; }

    public string EstadoReserva { get; set; } = null!;
}
