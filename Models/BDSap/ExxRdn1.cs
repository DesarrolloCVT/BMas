using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class ExxRdn1
{
    public int DocEntry { get; set; }

    public int LineId { get; set; }

    public int? VisOrder { get; set; }

    public string? Object { get; set; }

    public int? LogInst { get; set; }

    public string? UExxItemCode { get; set; }

    public decimal? UExxQuantity { get; set; }

    public decimal? UExxPrice { get; set; }

    public decimal? UExxPrecioBruto { get; set; }

    public decimal? UExxDescuento { get; set; }

    public string? UExxIndicador { get; set; }

    public decimal? UExxImpuesto { get; set; }

    public decimal? UExxTotal { get; set; }

    public string? UExxSlpCode { get; set; }

    public string? UExxSlpNombre { get; set; }

    public decimal? UPriceAfVatbefDi { get; set; }

    public string? UFreeTxt { get; set; }

    public string? UDscription { get; set; }

    public string? UCodeBars { get; set; }

    public decimal? UDiscPrcnt { get; set; }

    public decimal? UPriceBefDi { get; set; }

    public string? UWhsCode { get; set; }

    public DateTime? UShipDate { get; set; }

    public string? UUnitMsr { get; set; }

    public string? USpecPrice { get; set; }

    public string? ULegalText { get; set; }

    public string? UProject { get; set; }

    public string? UOcrCode { get; set; }

    public string? UOcrCode2 { get; set; }

    public string? UOcrCode3 { get; set; }

    public string? UOcrCode4 { get; set; }

    public string? UOcrCode5 { get; set; }

    public string? UIsGrossPrc { get; set; }

    public string? USalUnitMsr { get; set; }
}
