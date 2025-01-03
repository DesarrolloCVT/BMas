using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtviewPalletsRecSinPosicionar
{
    public string? Sitio { get; set; }

    public string? Bodega { get; set; }

    public int? Recepcion { get; set; }

    public string? Pallet { get; set; }

    public string? Lote { get; set; }

    public int CantidadInicial { get; set; }

    public int Cantidad { get; set; }

    public string? CodProducto { get; set; }

    public string? DescProducto { get; set; }

    public string? Proveedor { get; set; }

    public int? LayoutId { get; set; }

    public string? FechaIngreso { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Usuario { get; set; }
}
