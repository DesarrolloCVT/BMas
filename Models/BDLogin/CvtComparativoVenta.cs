using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtComparativoVenta
{
    public string Perdiodo { get; set; } = null!;

    public int? Mes { get; set; }

    public string? Vendedor { get; set; }

    public string? Marca { get; set; }

    public string? Canal { get; set; }

    public string? TipoNegocio { get; set; }

    public string? CodCliente { get; set; }

    public string? RazonSocial { get; set; }

    public string? Grupo { get; set; }

    public string? CodProducto { get; set; }

    public string? Producto { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Clp { get; set; }

    public decimal? ClpSrapel { get; set; }

    public decimal? CostoTotal { get; set; }

    public decimal? PrcRentabilidad { get; set; }
}
