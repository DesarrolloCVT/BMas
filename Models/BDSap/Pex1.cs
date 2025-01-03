using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pex1
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public DateTime? PayRunDate { get; set; }

    public int? PaymWizCod { get; set; }

    public string? VendorNum { get; set; }

    public string? CustNum { get; set; }

    public string? PaymMethod { get; set; }

    public int? PaymDocNum { get; set; }

    public DateTime? FiscalYear { get; set; }

    public string? VendRefNum { get; set; }

    public string? ObjType { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public string? CrdGlacct { get; set; }

    public string? DocCurr { get; set; }

    public decimal? DocRate { get; set; }

    public decimal? DocTotal { get; set; }

    public decimal? DocTotalFc { get; set; }

    public decimal? DocTaxAmnt { get; set; }

    public decimal? DoxTxAmtFc { get; set; }

    public string? DocRemarks { get; set; }

    public short? DocPrmTerm { get; set; }

    public string? DocPymRef { get; set; }

    public string? DocLocCurr { get; set; }

    public int? PymTermPer { get; set; }

    public int? DocNum { get; set; }

    public int? PymNum { get; set; }

    public int? PayOrderNo { get; set; }

    public string? FreeText1 { get; set; }

    public string? FreeText2 { get; set; }

    public string? FreeText3 { get; set; }

    public decimal? VatApplied { get; set; }
}
