using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Vrw2
{
    public int AbsEntry { get; set; }

    public int TaxInvId { get; set; }

    public string VatGroup { get; set; } = null!;

    public string? Selected { get; set; }

    public string? LineStatus { get; set; }

    public string? DebitAcc { get; set; }

    public DateTime? DocDate { get; set; }

    public decimal? VatAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public int? JetransId { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? Ref3 { get; set; }

    public string? Remarks { get; set; }

    public string? TrnsCode { get; set; }

    public int? Bplid { get; set; }

    public int Arinvabs { get; set; }

    public string? ArdocNumAb { get; set; }

    public int? ArabsEntry { get; set; }

    public string? ArobjType { get; set; }

    public DateTime? ArdocDate { get; set; }

    public string? CstmrCode { get; set; }

    public string? CstmrName { get; set; }

    public int? TpiDocNum { get; set; }

    public DateTime? TpiDocDate { get; set; }

    public string? VendorCode { get; set; }

    public string? VendorName { get; set; }

    public string? ArdocMemo { get; set; }

    public string? TpiMemo { get; set; }

    public decimal? GrsAmt { get; set; }

    public string? VatAcc { get; set; }

    public decimal? OpenVatAmt { get; set; }

    public decimal? OpenNetAmt { get; set; }

    public decimal? OpenGrsAmt { get; set; }

    public decimal? RepstedVat { get; set; }
}
