using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class NxContabap
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public string? UNxEstadoAp { get; set; }

    public string? UNxRutEmisor { get; set; }

    public string? UNxRsemisor { get; set; }

    public string? UNxTipoDte { get; set; }

    public string? UNxFolioDte { get; set; }

    public string? UNxRutReceptor { get; set; }

    public string? UNxRsreceptor { get; set; }

    public string? UNxCsreceptor { get; set; }

    public DateTime? UNxFechaEmision { get; set; }

    public DateTime? UNxFechaAprobacion { get; set; }

    public string? UNxUserSignature { get; set; }

    public DateTime? UNxFechaFirma { get; set; }

    public DateTime? UNxFechaRegistroSii { get; set; }

    public DateTime? UNxFechaContabilizacion { get; set; }

    public string? UNxDocType { get; set; }

    public decimal? UNxNeto { get; set; }

    public decimal? UNxIva { get; set; }

    public decimal? UNxExento { get; set; }

    public decimal? UNxTotal { get; set; }

    public decimal? UNxOtros { get; set; }

    public string? UNxEstadoRecepcion { get; set; }

    public string? UNxGlosaEstadoRecepcion { get; set; }

    public string? UNxEstadoLey19983 { get; set; }

    public string? UNxGlosaEstadoLey19983 { get; set; }

    public string? UNxEstadoLey20956 { get; set; }

    public string? UNxGlosaEstadoLey20956 { get; set; }

    public string? UNxCodigoImpuesto { get; set; }

    public string? UNxConceptoGasto { get; set; }

    public string? UNxCuentaContable { get; set; }

    public string? UNxItemCode { get; set; }

    public string? UNxDim1 { get; set; }

    public string? UNxDim1N { get; set; }

    public string? UNxDim2 { get; set; }

    public string? UNxDim2N { get; set; }

    public string? UNxDim3 { get; set; }

    public string? UNxDim3N { get; set; }

    public string? UNxDim4 { get; set; }

    public string? UNxDim4N { get; set; }

    public string? UNxDim5 { get; set; }

    public string? UNxDim5N { get; set; }

    public string? UNxProy { get; set; }

    public string? UNxProyN { get; set; }

    public string? UNxDocNum { get; set; }

    public string? UNxDocNumP { get; set; }

    public string? UNxComentarios { get; set; }

    public string? UNxUserSignature2 { get; set; }

    public string? UNxContabilizado { get; set; }

    public string? UNxOcrefs { get; set; }

    public string? UNxOcsaprefs { get; set; }

    public string? UNxGdrefs { get; set; }

    public string? UNxGdsaprefs { get; set; }

    public string? UNxRefImg { get; set; }
}
