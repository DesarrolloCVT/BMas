using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ipf1
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int? BaseType { get; set; }

    public int? BaseEntry { get; set; }

    public string? ItemCode { get; set; }

    public string? Dscription { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? PriceFob { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Custom { get; set; }

    public decimal? CustomFc { get; set; }

    public decimal? Cost { get; set; }

    public decimal? CostFc { get; set; }

    public decimal? PriceAtWh { get; set; }

    public decimal? PricAtWhfc { get; set; }

    public decimal? LineTotal { get; set; }

    public decimal? TotalFrgn { get; set; }

    public decimal? Volume { get; set; }

    public short? UnitCode { get; set; }

    public decimal? Weight1 { get; set; }

    public short? UnitCode1 { get; set; }

    public decimal? Weight2 { get; set; }

    public short? UnitCode2 { get; set; }

    public string? CardCode { get; set; }

    public string? Reference { get; set; }

    public int? OrigLine { get; set; }

    public decimal? FactNoCust { get; set; }

    public decimal? FacWthCust { get; set; }

    public short? PriceList { get; set; }

    public string? CostOh { get; set; }

    public string? StockEval { get; set; }

    public string? UseBaseUn { get; set; }

    public string? BlockNum { get; set; }

    public string? ImportLog { get; set; }

    public string? WhsCode { get; set; }

    public int? OrigRow { get; set; }

    public string? Locked { get; set; }

    public string? OrigWhs { get; set; }

    public int? ReleaseNum { get; set; }

    public decimal? VarCosts { get; set; }

    public decimal? ConstCosts { get; set; }

    public decimal? VarCostsFr { get; set; }

    public decimal? CnstCostFr { get; set; }

    public decimal? UserCustom { get; set; }

    public decimal? UsrCusomFc { get; set; }

    public decimal? FobValue { get; set; }

    public decimal? FobValueFc { get; set; }

    public decimal? TtlExpndLc { get; set; }

    public decimal? TtlExpndFc { get; set; }

    public decimal? TtlCustLc { get; set; }

    public decimal? TtlCustFc { get; set; }

    public decimal? TtlCostLc { get; set; }

    public decimal? TtlCostFc { get; set; }

    public decimal? TtlVolume { get; set; }

    public decimal? TtlWeight { get; set; }

    public int? BaseRowNum { get; set; }

    public decimal? TtlCustSc { get; set; }

    public decimal? TtlExpndSc { get; set; }

    public int? OriBabsEnt { get; set; }

    public int? OriBlinNum { get; set; }

    public int? TargetDoc { get; set; }

    public string? FobValCurr { get; set; }

    public decimal? FobnLaC { get; set; }

    public decimal? FobnLaCfc { get; set; }

    public decimal? NumPerMsr { get; set; }

    public string? Project { get; set; }

    public string? OcrCode { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public string? OriBdocTyp { get; set; }

    public decimal? CustRate { get; set; }

    public decimal? LfixCost { get; set; }

    public decimal? LfixCostFc { get; set; }

    public decimal? LvarCost { get; set; }

    public decimal? LvarCostFc { get; set; }

    public decimal? CstmsRate { get; set; }

    public string? VatGroup { get; set; }

    public decimal? VatPrcnt { get; set; }

    public decimal? VatSum { get; set; }

    public string? SnbType { get; set; }

    public int? SnbAbsEnt { get; set; }

    public int? SysNumber { get; set; }

    public string? DistNumber { get; set; }

    public decimal? ExciseSum { get; set; }

    public decimal? ExcisSumFc { get; set; }

    public string? ExcInStk { get; set; }

    public decimal? CustomSum { get; set; }

    public decimal? CustSumFc { get; set; }

    public string? CstmInStk { get; set; }

    public decimal? CstmVatSum { get; set; }

    public decimal? CstmVatFc { get; set; }

    public string? CstmVatStk { get; set; }

    public int? Ccdentry { get; set; }

    public string? Ccdnumber { get; set; }

    public decimal? ExcisSumSc { get; set; }

    public decimal? CustSumSc { get; set; }

    public decimal? CstmVatSc { get; set; }

    public decimal? InvQty { get; set; }

    public int? CcdlineNum { get; set; }

    public decimal? TtlVolCcm { get; set; }

    public decimal? ExcImpQty { get; set; }

    public decimal? ExcFixAmnt { get; set; }

    public decimal? ExcRate { get; set; }

    public decimal? ExcAmntUoM { get; set; }

    public decimal? ExcAmntAdV { get; set; }

    public int? ExcImpQuoM { get; set; }

    public decimal? ExcBasAmnt { get; set; }

    public int? LineNumV3 { get; set; }

    public decimal? FobVal2 { get; set; }

    public decimal? FobVal2Fc { get; set; }

    public string? EncryptIv { get; set; }
}
