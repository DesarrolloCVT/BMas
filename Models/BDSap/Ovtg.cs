using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ovtg
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? EffecDate { get; set; }

    public string? Category { get; set; }

    public string? Account { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? IsEc { get; set; }

    public string? Indicator { get; set; }

    public string? AcqstnRvrs { get; set; }

    public decimal? NonDedct { get; set; }

    public string? AcqsTax { get; set; }

    public string? GoddsShip { get; set; }

    public string? NonDedAcc { get; set; }

    public string? DeferrAcc { get; set; }

    public decimal? EquVatPr { get; set; }

    public string? ReportCode { get; set; }

    public string? FixdAssts { get; set; }

    public string? CalcMethod { get; set; }

    public string? TaxType { get; set; }

    public decimal? FixedAmnt { get; set; }

    public string? ExtCode { get; set; }

    public string? Correction { get; set; }

    public string? VatCrctn { get; set; }

    public string? RetVatCode { get; set; }

    public int? RepType { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? TaxCtgr { get; set; }

    public string? EquAccount { get; set; }

    public short? UserSign2 { get; set; }

    public string? IsIgic { get; set; }

    public string? ServSupply { get; set; }

    public string? Inactive { get; set; }

    public string? TaxCtgrBl { get; set; }

    public int? R349code { get; set; }

    public string? VatRevAcc { get; set; }

    public string? CashDisAcc { get; set; }

    public string? DpmTaxOacc { get; set; }

    public string? VatDedAcc { get; set; }

    public string? CstmExpAcc { get; set; }

    public string? CstmAlcAcc { get; set; }

    public string? TaxRegion { get; set; }

    public string? ExemReason { get; set; }

    public string? Agent { get; set; }

    public string? OpCode { get; set; }

    public string? Export { get; set; }

    public string? Section { get; set; }

    public string? SplitPaymt { get; set; }

    public string? SplitPayAc { get; set; }

    public string? TaxAgent { get; set; }

    public string? SectionLim { get; set; }

    public string? VatSubjCod { get; set; }

    public int? VatType { get; set; }

    public int? VatCategor { get; set; }

    public string? Parag44 { get; set; }

    public string? ProrataDed { get; set; }

    public string? ExcFrmTaxS { get; set; }

    public string? CstmActing { get; set; }

    public string? CstmActOut { get; set; }

    public string? StdTaxCode { get; set; }

    public string? AcqRevTax { get; set; }

    public string? ExReasonHu { get; set; }

    public string? ExRemarkHu { get; set; }

    public int? EbvatCateg { get; set; }
}
