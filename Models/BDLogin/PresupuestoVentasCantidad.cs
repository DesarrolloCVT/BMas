using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class PresupuestoVentasCantidad
{
    public int Id { get; set; }

    public int? CodVendedor { get; set; }

    public string? Vendedor { get; set; }

    public string? CodCliente { get; set; }

    public string? RazonSocial { get; set; }

    public string? TipoNegocio { get; set; }

    public string? Canal { get; set; }

    public string? CodProducto { get; set; }

    public string? Producto { get; set; }

    public string? Grupo { get; set; }

    public string? Marca { get; set; }

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public decimal? Valor { get; set; }
}
