using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class NxRegap
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public string? UNxRutEmisor { get; set; }

    public string? UNxRsemisor { get; set; }

    public string? UNxTipoDte { get; set; }

    public string? UNxFolioDte { get; set; }

    public string? UNxRutReceptor { get; set; }

    public string? UNxRsreceptor { get; set; }

    public string? UNxCsreceptor { get; set; }

    public DateTime? UNxFechaEmision { get; set; }

    public DateTime? UNxFechaFirma { get; set; }

    public DateTime? UNxFechaRegistroSii { get; set; }

    public DateTime? UNxFechaAprobacion { get; set; }

    public decimal? UNxNeto { get; set; }

    public decimal? UNxIva { get; set; }

    public decimal? UNxExento { get; set; }

    public decimal? UNxOtros { get; set; }

    public decimal? UNxTotal { get; set; }

    public string? UNxEstadoRecepcion { get; set; }

    public string? UNxGlosaEstadoRecepcion { get; set; }

    public string? UNxEstadoLey19983 { get; set; }

    public string? UNxGlosaEstadoLey19983 { get; set; }

    public string? UNxEstadoLey20956 { get; set; }

    public string? UNxGlosaEstadoLey20956 { get; set; }

    public string? UNxEstadoAp { get; set; }

    public string? UNxInvalidRefSn { get; set; }

    public string? UNxDetalleRefSn { get; set; }

    public string? UNxInvalidRefPrj { get; set; }

    public string? UNxDetalleRefPrj { get; set; }

    public string? UNxOcrefs { get; set; }

    public string? UNxOcsaprefs { get; set; }

    public string? UNxGdrefs { get; set; }

    public string? UNxGdsaprefs { get; set; }

    public string? UNxUserConsulta { get; set; }
}
