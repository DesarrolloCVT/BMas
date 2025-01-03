using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class EstadisticaVenta
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public DateTime? FechaContab { get; set; }

    public DateTime? FechaVenc { get; set; }

    public int? CompContable { get; set; }

    public int? Folio { get; set; }

    public int? NumInterno { get; set; }

    public string? CodCliente { get; set; }

    public string? RazonSocial { get; set; }

    public int? GrupoProducto { get; set; }

    public string? NombreGrupoProducto { get; set; }

    public string? Producto { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public decimal? Costo { get; set; }

    public decimal? TotalLinea { get; set; }

    public string? Indicador { get; set; }

    public decimal? ProcentajeRapel { get; set; }

    public decimal? PrecioSinRapel { get; set; }

    public string? DireccionEnvio { get; set; }

    public string? Ciudad { get; set; }

    public string? TipoVenta { get; set; }

    public decimal? CostoFinal { get; set; }

    public decimal? Peso { get; set; }

    public string? Marca { get; set; }

    public string? Canal { get; set; }

    public string? TipoNegocio { get; set; }

    public string? Vendedor { get; set; }

    public string? TipoMarca { get; set; }
}
