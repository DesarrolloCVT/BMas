using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwDevolucionPbi
{
    public string? CodCliente { get; set; }

    public string? Cliente { get; set; }

    public DateTime? FechaDevolucion { get; set; }

    public string Grupo { get; set; } = null!;

    public string? CodProducto { get; set; }

    public string? Producto { get; set; }

    public decimal? Cantidad { get; set; }

    public string CodMotivo { get; set; } = null!;

    public string Motivo { get; set; } = null!;

    public int? FolioDevolucionWms { get; set; }

    public string? UsuarioReceptorDevolucion { get; set; }

    public string? FolioFactura { get; set; }

    public string? RazonGlobalDevolucion { get; set; }

    public string? PatenteCamion { get; set; }

    public DateTime? FechaFactura { get; set; }

    public decimal? Kilos { get; set; }

    public string AreaResponsable { get; set; } = null!;

    public int? NpedidoWms { get; set; }

    public string? UsuarioDespachador { get; set; }

    public int? NpedidoSap { get; set; }

    public decimal? PesoTotalDevolucion { get; set; }

    public decimal? MontoTotalDevolucion { get; set; }

    public decimal? PesoTotalFactura { get; set; }

    public decimal? MontoTotalFactura { get; set; }
}
