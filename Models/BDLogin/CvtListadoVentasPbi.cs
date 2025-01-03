using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtListadoVentasPbi
{
    public string? Tipo { get; set; }

    public string? TipoDocumento { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public DateTime? FCont { get; set; }

    public DateTime? FVenc { get; set; }

    public int? CompConta { get; set; }

    public int? Folio { get; set; }

    public int? NumInterno { get; set; }

    public string? Indicador { get; set; }

    public string GrupoCliente { get; set; } = null!;

    public string? CodCliente { get; set; }

    public string? RazonSocial { get; set; }

    public string? GrupoArticulo { get; set; }

    public string? CodigoArticulo { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public decimal? TotalLinea { get; set; }

    public decimal? Costo { get; set; }

    public decimal? CostoTotal { get; set; }

    public decimal PrcRapel { get; set; }

    public decimal? TotalRapel { get; set; }

    public decimal? TotalSinRapel { get; set; }

    public decimal PesoTotal { get; set; }

    public string? CodDireccion { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? NumRegion { get; set; }

    public string? Comuna { get; set; }

    public string? Transporte { get; set; }

    public int Distancia { get; set; }

    public int? ValorTransporte { get; set; }

    public decimal? ValorProductoTransporte { get; set; }

    public int? BasePalletizado { get; set; }

    public int? PalletEstandar { get; set; }

    public string? Vendedor { get; set; }

    public string? Marca { get; set; }

    public string? Canal { get; set; }

    public string? GrupoVenta { get; set; }

    public string? EmpresaRelacionada { get; set; }

    public string TipoMarca { get; set; } = null!;

    public string? UmVendida { get; set; }

    public string? UmEmbalaje { get; set; }

    public decimal EmbalajePorUm { get; set; }

    public decimal UnidadesVendidas { get; set; }

    public string? TipoDocRef { get; set; }

    public string? NumDocRef { get; set; }

    public string? Comentario { get; set; }

    public decimal PrcRAcuerdo { get; set; }

    public decimal? TotalRAcuerdo { get; set; }

    public decimal PrcRCentra { get; set; }

    public decimal? TotalRCentra { get; set; }

    public decimal PrcRRepoInt { get; set; }

    public decimal? TotalRRepoInt { get; set; }

    public decimal PrcRDaymon { get; set; }

    public decimal? TotalRDaymon { get; set; }

    public decimal PrcRLogAuto { get; set; }

    public decimal? TotalRLogAuto { get; set; }

    public decimal PrcRMermaCero { get; set; }

    public decimal? TotalRMermaCero { get; set; }

    public decimal PrcRPlataforma { get; set; }

    public decimal? TotalRPlataforma { get; set; }

    public decimal PrcRFcrappel { get; set; }

    public decimal? TotalRFcrappel { get; set; }

    public decimal PcrComision { get; set; }

    public string? TipoComision { get; set; }

    public decimal? TotalComision { get; set; }

    public decimal? UtilidadBruta { get; set; }

    public decimal? MargenBruto { get; set; }

    public decimal? UtilidadRealCt { get; set; }

    public decimal? MargenReal { get; set; }

    public decimal? UtilidadRc { get; set; }

    public decimal? MargeRc { get; set; }

    public decimal NotaBruta { get; set; }

    public decimal NotaReal { get; set; }

    public decimal NotaRc { get; set; }

    public int? SlpCode { get; set; }
}
