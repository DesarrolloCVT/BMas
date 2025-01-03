using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rPreventa1
{
    public int DocEntry { get; set; }

    public int LineId { get; set; }

    public int? VisOrder { get; set; }

    public string? Object { get; set; }

    public int? LogInst { get; set; }

    public string? UItemCode { get; set; }

    public string? UDscription { get; set; }

    public string? UCodeBars { get; set; }

    public decimal? UQuantity { get; set; }

    public decimal? UDiscPrcnt { get; set; }

    public decimal? UPriceBefDi { get; set; }

    public decimal? UPrice { get; set; }

    public decimal? UPriceAfVat { get; set; }

    public decimal? UPriceAfVatbefDi { get; set; }

    public string? UTaxCode { get; set; }

    public decimal? UVatPrcnt { get; set; }

    public string? UWhsCode { get; set; }

    public DateTime? UShipDate { get; set; }

    public string? UUnitMsr { get; set; }

    public decimal? UGtotal { get; set; }

    public string? USpecPrice { get; set; }

    public int? USlpCode { get; set; }

    public string? UFreeTxt { get; set; }

    public string? ULegalText { get; set; }

    public string? UProject { get; set; }

    public string? UOcrCode { get; set; }

    public string? UOcrCode2 { get; set; }

    public string? UOcrCode3 { get; set; }

    public string? UOcrCode4 { get; set; }

    public string? UOcrCode5 { get; set; }

    public decimal? UDescuento { get; set; }

    public string? UIsGrossPrc { get; set; }

    public string? USalUnitMsr { get; set; }
}
