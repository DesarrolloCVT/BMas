using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SboFelectCabecera
{
    public string Tipo { get; set; } = null!;

    public int? DocEntry { get; set; }

    public string? ObjType { get; set; }

    public string? DocSubType { get; set; }

    public string? NombreReceptor { get; set; }

    public string? RutReceptor { get; set; }

    public string? GiroReceptor { get; set; }

    public string? EmailReceptor { get; set; }

    public string? TelefonoReceptor { get; set; }

    public string? DireccionFactura { get; set; }

    public string? ComunaFactura { get; set; }

    public string? CiudadFactura { get; set; }

    public string DireccionDespacho { get; set; } = null!;

    public string? ComunaDespacho { get; set; }

    public string? CiudadDespacho { get; set; }

    public string? Folio { get; set; }

    public DateTime? FechaEmision { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string? Comentarios { get; set; }

    public string Vendedor { get; set; } = null!;

    public string? FormaPago { get; set; }

    public string Codpago { get; set; } = null!;

    public string? UsuarioSap { get; set; }

    public string PersonaContacto { get; set; } = null!;

    public string MailContacto { get; set; } = null!;

    public string? TipoDespacho { get; set; }

    public string? TipoTraslado { get; set; }

    public string? NombreChofer { get; set; }

    public string? RutChofer { get; set; }

    public string? Patente { get; set; }

    public string? Tdbsii { get; set; }

    public string? Foliodb { get; set; }

    public DateTime? Fechadb { get; set; }

    public string? Codrefdb { get; set; }

    public string Tdbsii1 { get; set; } = null!;

    public string Foliodb1 { get; set; } = null!;

    public string Fechadb1 { get; set; } = null!;

    public string Codrefdb1 { get; set; } = null!;

    public string? NumeroOc { get; set; }

    public DateTime? FechaOc { get; set; }

    public string Origen { get; set; } = null!;

    public string Destino { get; set; } = null!;

    public string Indicador { get; set; } = null!;

    public string Notaventa { get; set; } = null!;

    public string Folionotaventa { get; set; } = null!;

    public string Fechanotaventa { get; set; } = null!;

    public decimal? Subtotal { get; set; }

    public decimal PrctDscto { get; set; }

    public decimal MontoDscto { get; set; }

    public decimal? Neto { get; set; }

    public decimal DescAfectoGlobal { get; set; }

    public decimal? Exento { get; set; }

    public decimal? DescExentoGlobal { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Total { get; set; }

    public string TasaIva { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public string DireccionEmisor { get; set; } = null!;

    public string RutEmisor { get; set; } = null!;

    public int? DocNum { get; set; }

    public string? UsuarioCaja { get; set; }

    public decimal? PagoConTarjeta { get; set; }

    public decimal? PagoEfectivo { get; set; }

    public decimal? Vuelto { get; set; }

    public decimal? Ila10bn { get; set; }

    public decimal? Ila18be { get; set; }

    public decimal? Ila20ce { get; set; }

    public decimal? Ila20vc { get; set; }

    public decimal? Ila31pl { get; set; }

    public decimal? Ha { get; set; }

    public string? TipoVenta { get; set; }

    public string Reserva16 { get; set; } = null!;

    public string Reserva17 { get; set; } = null!;

    public string Reserva18 { get; set; } = null!;
}
