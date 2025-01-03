using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class ViewResumenEstadisticasVenta
{
    public string? Tipo { get; set; }

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public string? CodCliente { get; set; }

    public string? RazonSocial { get; set; }

    public int? GrupoProducto { get; set; }

    public string? NombreGrupoProducto { get; set; }

    public string? Producto { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Clp { get; set; }

    public decimal? Psr { get; set; }

    public string? Marca { get; set; }

    public string? Canal { get; set; }

    public string? TipoNegocio { get; set; }

    public string? Vendedor { get; set; }

    public string? TipoVenta { get; set; }
}
