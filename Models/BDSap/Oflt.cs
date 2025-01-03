using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oflt
{
    public string FormNum { get; set; } = null!;

    public string? QueryStr { get; set; }

    public string? ItmOrCrd { get; set; }

    public string? CardInclud { get; set; }

    public string? CardFrom1 { get; set; }

    public string? CardTo1 { get; set; }

    public string? CardExclud { get; set; }

    public string? CardFrom2 { get; set; }

    public string? CardTo2 { get; set; }

    public short? ClienGroup { get; set; }

    public short? VendGroup { get; set; }

    public string? ClntQryGrp { get; set; }

    public string? VeQryGroup { get; set; }

    public string? ItmInclud { get; set; }

    public string? ItmFrom1 { get; set; }

    public string? ItmTo1 { get; set; }

    public string? ItmExclud { get; set; }

    public string? ItmFrom2 { get; set; }

    public string? ItmTo2 { get; set; }

    public short? ItmGroup { get; set; }

    public string? ItQryGroup { get; set; }

    public string? WhsInclude { get; set; }

    public string? WhsFrom1 { get; set; }

    public string? WhsTo1 { get; set; }

    public string? WhsExclude { get; set; }

    public string? WhsFrom2 { get; set; }

    public string? WhsTo2 { get; set; }

    public string? FromAcct { get; set; }

    public string? ToAcct { get; set; }

    public string? GroupMask { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public DateTime? FrmDueDate { get; set; }

    public DateTime? ToDueDate { get; set; }

    public DateTime? FromDate3 { get; set; }

    public DateTime? ToDate3 { get; set; }

    public DateTime? FromDate4 { get; set; }

    public DateTime? ToDate4 { get; set; }

    public short? SourceType { get; set; }

    public int? FrmTrnsNum { get; set; }

    public int? ToTrnsNum { get; set; }

    public string? FromRef1 { get; set; }

    public string? ToRef1 { get; set; }

    public string? FromRef2 { get; set; }

    public string? ToRef2 { get; set; }

    public string? FrmTrnsCod { get; set; }

    public string? ToTrnsCod { get; set; }

    public decimal? FromSum { get; set; }

    public decimal? ToSum { get; set; }

    public decimal? FrmFrnamnt { get; set; }

    public decimal? ToFrnamnt { get; set; }

    public string? MemoIn { get; set; }

    public short? SortField1 { get; set; }

    public string? Break1 { get; set; }

    public short? SortField2 { get; set; }

    public string? Break2 { get; set; }

    public short? SortField3 { get; set; }

    public string? Break3 { get; set; }

    public string? Display { get; set; }

    public string? PrntCutDat { get; set; }

    public string? CheckBox0 { get; set; }

    public string? CheckBox1 { get; set; }

    public string? CheckBox2 { get; set; }

    public string? CheckBox3 { get; set; }

    public string? CheckBox4 { get; set; }

    public string? CheckBox5 { get; set; }

    public string? CheckBox6 { get; set; }

    public string? CheckBox7 { get; set; }

    public string? CheckBox8 { get; set; }

    public string? CheckBox9 { get; set; }

    public string? ShowZero { get; set; }

    public string? DateCheck { get; set; }

    public string? DueCheck { get; set; }

    public string? CutCheck { get; set; }

    public string? CutByObj { get; set; }

    public string? ObjectC1 { get; set; }

    public string? ObjectC2 { get; set; }

    public string? ObjectC3 { get; set; }

    public string? ObjectC4 { get; set; }

    public string? ObjectC5 { get; set; }

    public string? ObjectC6 { get; set; }

    public string? ObjectC7 { get; set; }

    public string? ObjectC8 { get; set; }

    public string? ObjectC9 { get; set; }

    public string? ObjectC10 { get; set; }

    public string? ObjectC11 { get; set; }

    public string? ObjectC12 { get; set; }

    public string? ObjectC13 { get; set; }

    public string? ObjectC14 { get; set; }

    public string? ObjectC15 { get; set; }

    public string? ObjectC16 { get; set; }

    public decimal? FromAmount { get; set; }

    public decimal? ToAmount { get; set; }

    public short? FrmSalsMan { get; set; }

    public short? ToSalsMan { get; set; }

    public string? UserChk1 { get; set; }

    public string? UserChk2 { get; set; }

    public string? UserChk3 { get; set; }

    public string? UserChk4 { get; set; }

    public string? UserChk5 { get; set; }

    public string? UseSort { get; set; }

    public string? Sort1Up { get; set; }

    public string? Sort2Up { get; set; }

    public string? Sort3Up { get; set; }

    public decimal? FromAmnt2 { get; set; }

    public decimal? ToAmount2 { get; set; }

    public DateTime? TaxDateFro { get; set; }

    public DateTime? TaxDateTo { get; set; }

    public DateTime? FinancYear { get; set; }

    public int? BdgtScenar { get; set; }

    public string? CompFolder { get; set; }

    public string? CheckBox10 { get; set; }

    public decimal? FromFc { get; set; }

    public decimal? ToFc { get; set; }

    public string? Fccurrency { get; set; }

    public string? TaxCheck { get; set; }

    public string? DateType { get; set; }

    public string? DateType2 { get; set; }

    public string? FromPrject { get; set; }

    public string? ToProject { get; set; }

    public int? TemplateId { get; set; }

    public string? ShowLeads { get; set; }

    public string? MthDate { get; set; }

    public string? AccntntCod { get; set; }

    public short UserSign { get; set; }

    public string? BlcNunFrom { get; set; }

    public string? BlcNunTo { get; set; }

    public string? ImpLogFrom { get; set; }

    public string? ImpLogTo { get; set; }

    public string? FolderNum { get; set; }

    public short? MainField { get; set; }

    public string? TransMode { get; set; }

    public string? MonthMode { get; set; }

    public string? CheckBox11 { get; set; }

    public string? FromIdc { get; set; }

    public string? ToIdc { get; set; }

    public string? IgnoreAdj { get; set; }

    public string? RefNumFrom { get; set; }

    public string? RefNumTo { get; set; }

    public int? PymNumfrom { get; set; }

    public int? PymNumTo { get; set; }

    public string? BankFrom { get; set; }

    public string? BankTo { get; set; }

    public int? DpstFrom { get; set; }

    public int? DpstTo { get; set; }

    public string? DpstType { get; set; }

    public string? ObjectC17 { get; set; }

    public string? ObjectC18 { get; set; }

    public string? ObjectC19 { get; set; }

    public int? ObjAbs { get; set; }

    public string? AddBtf { get; set; }

    public string? FilePath { get; set; }

    public string? DpsBnkActF { get; set; }

    public string? DpsBnkActT { get; set; }

    public int? FromKey { get; set; }

    public int? ToKey { get; set; }

    public string? ObjectC20 { get; set; }

    public string? ObjectC21 { get; set; }

    public string? ObjectC22 { get; set; }

    public string? ObjectC23 { get; set; }

    public string? ObjectC25 { get; set; }

    public string? UserChk6 { get; set; }

    public string? OcrChkDim2 { get; set; }

    public string? OcrChkDim3 { get; set; }

    public string? OcrChkDim4 { get; set; }

    public string? OcrChkDim5 { get; set; }

    public string? OcrFrom2 { get; set; }

    public string? OcrFrom3 { get; set; }

    public string? OcrFrom4 { get; set; }

    public string? OcrFrom5 { get; set; }

    public string? OcrTo2 { get; set; }

    public string? OcrTo3 { get; set; }

    public string? OcrTo4 { get; set; }

    public string? OcrTo5 { get; set; }

    public string? TaxAdjRep { get; set; }

    public string? ObjectC26 { get; set; }

    public string? Cbfilter { get; set; }

    public string? Obincluded { get; set; }

    public string? Obfilter { get; set; }

    public string? ExportCurr { get; set; }

    public string? Cbincluded { get; set; }

    public string? SlpFrom { get; set; }

    public string? SlpTo { get; set; }

    public string? Cbudf { get; set; }

    public string? Cbref { get; set; }

    public string? CheckBoxB { get; set; }

    public string FilterName { get; set; } = null!;

    public short? JdtfixedF { get; set; }

    public short? Jdt1fixedF { get; set; }

    public short? JdtuserF { get; set; }

    public short? Jdt1userF { get; set; }

    public string? Bpfilter { get; set; }

    public string? AcctFltr { get; set; }

    public string? ZeroLcamt { get; set; }

    public string? SplitByBin { get; set; }

    public string? SplitBySnb { get; set; }

    public string? CheckBox12 { get; set; }

    public string? CheckBox13 { get; set; }

    public string? CheckBox14 { get; set; }

    public string? CheckBox15 { get; set; }

    public string? CheckBox16 { get; set; }

    public string? CheckBox17 { get; set; }

    public string? CheckBox18 { get; set; }

    public string? CheckBox19 { get; set; }

    public string? CheckBox20 { get; set; }

    public string? CheckBox21 { get; set; }

    public string? CheckBox22 { get; set; }

    public string? CheckBox23 { get; set; }

    public string? CheckBox24 { get; set; }

    public string? CheckBox25 { get; set; }

    public string? CheckBox26 { get; set; }

    public string? CheckBox27 { get; set; }

    public string? CheckBox28 { get; set; }

    public string? CheckBox29 { get; set; }

    public string? CheckBox30 { get; set; }

    public string? CheckBox31 { get; set; }

    public string? CheckBox32 { get; set; }

    public string? CheckBox33 { get; set; }

    public string? BatchFrom { get; set; }

    public string? BatchTo { get; set; }

    public string? BatAttr1F { get; set; }

    public string? BatAttr1T { get; set; }

    public string? BatAttr2F { get; set; }

    public string? BatAttr2T { get; set; }

    public string? SerialNoF { get; set; }

    public string? SerialNoT { get; set; }

    public string? MfrSerailF { get; set; }

    public string? MfrSerailT { get; set; }

    public string? LotNumberF { get; set; }

    public string? LotNumberT { get; set; }

    public string? BinLocFrom { get; set; }

    public string? BinLocTo { get; set; }

    public string? AltSrtCodF { get; set; }

    public string? AltSrtCodT { get; set; }

    public string? BinSbl1F { get; set; }

    public string? BinSbl1To { get; set; }

    public string? BinSbl2F { get; set; }

    public string? BinSbl2To { get; set; }

    public string? BinSbl3F { get; set; }

    public string? BinSbl3To { get; set; }

    public string? BinSbl4F { get; set; }

    public string? BinSbl4To { get; set; }

    public string? BinAttr1F { get; set; }

    public string? BinAttr1To { get; set; }

    public string? BinAttr2F { get; set; }

    public string? BinAttr2To { get; set; }

    public string? BinAttr3F { get; set; }

    public string? BinAttr3To { get; set; }

    public string? BinAttr4F { get; set; }

    public string? BinAttr4To { get; set; }

    public string? BinAttr5F { get; set; }

    public string? BinAttr5To { get; set; }

    public string? BinAttr6F { get; set; }

    public string? BinAttr6To { get; set; }

    public string? BinAttr7F { get; set; }

    public string? BinAttr7To { get; set; }

    public string? BinAttr8F { get; set; }

    public string? BinAttr8To { get; set; }

    public string? BinAttr9F { get; set; }

    public string? BinAttr9To { get; set; }

    public string? BinAttr10F { get; set; }

    public string? BinAttr10T { get; set; }

    public string? EnfBinFltr { get; set; }

    public string? ExItemFrom { get; set; }

    public string? ExItemTo { get; set; }

    public string? ExBpfrom { get; set; }

    public string? ExBpto { get; set; }

    public string? CheckBox34 { get; set; }

    public string? CheckBox35 { get; set; }

    public string? BlAgreem { get; set; }

    public string? Bafrom { get; set; }

    public string? Bato { get; set; }

    public string? AdjTrans { get; set; }

    public int? TitAcctLvl { get; set; }

    public string? Ccdfrom1 { get; set; }

    public string? Ccdto1 { get; set; }

    public string? Ccdfrom2 { get; set; }

    public string? Ccdto2 { get; set; }

    public string? ArchJrnal { get; set; }

    public string? CardFrom3 { get; set; }

    public string? CardTo3 { get; set; }

    public string? Obbranch { get; set; }

    public string? AccumDbCr { get; set; }

    public string? RscFrom1 { get; set; }

    public string? RscTo1 { get; set; }

    public short? RscGroup { get; set; }

    public string? RouteStage { get; set; }

    public int? ExRstfrom { get; set; }

    public int? ExRstto { get; set; }

    public string? StgSeqNum { get; set; }

    public int? ExSsnfrom { get; set; }

    public int? ExSsnto { get; set; }
}
