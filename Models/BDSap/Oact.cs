using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oact
{
    public string AcctCode { get; set; } = null!;

    public string? AcctName { get; set; }

    public decimal? CurrTotal { get; set; }

    public decimal? EndTotal { get; set; }

    public string? Finanse { get; set; }

    public string? Groups { get; set; }

    public string? Budget { get; set; }

    public string? Frozen { get; set; }

    public string? Free2 { get; set; }

    public string? Postable { get; set; }

    public string? Fixed { get; set; }

    public short? Levels { get; set; }

    public string? ExportCode { get; set; }

    public int? GrpLine { get; set; }

    public string? FatherNum { get; set; }

    public string? AccntntCod { get; set; }

    public string? CashBox { get; set; }

    public short? GroupMask { get; set; }

    public string? RateTrans { get; set; }

    public string? TaxIncome { get; set; }

    public string? ExmIncome { get; set; }

    public int? ExtrMatch { get; set; }

    public int? IntrMatch { get; set; }

    public string? ActType { get; set; }

    public string? Transfered { get; set; }

    public string? BlncTrnsfr { get; set; }

    public string? OverType { get; set; }

    public string? OverCode { get; set; }

    public int? SysMatch { get; set; }

    public string? PrevYear { get; set; }

    public string? ActCurr { get; set; }

    public string? RateDifAct { get; set; }

    public decimal? SysTotal { get; set; }

    public decimal? FcTotal { get; set; }

    public string? Protected { get; set; }

    public string? RealAcct { get; set; }

    public string? Advance { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? FrgnName { get; set; }

    public string? Details { get; set; }

    public decimal? ExtraSum { get; set; }

    public string? Project { get; set; }

    public string? RevalMatch { get; set; }

    public string? DataSource { get; set; }

    public string? LocMth { get; set; }

    public int? Mthcounter { get; set; }

    public int? Bnkcounter { get; set; }

    public short? UserSign { get; set; }

    public string? LocManTran { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjType { get; set; }

    public string? ValidFor { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? ValidComm { get; set; }

    public string? FrozenFor { get; set; }

    public DateTime? FrozenFrom { get; set; }

    public DateTime? FrozenTo { get; set; }

    public string? FrozenComm { get; set; }

    public int? Counter { get; set; }

    public string? Segment0 { get; set; }

    public string? Segment1 { get; set; }

    public string? Segment2 { get; set; }

    public string? Segment3 { get; set; }

    public string? Segment4 { get; set; }

    public string? Segment5 { get; set; }

    public string? Segment6 { get; set; }

    public string? Segment7 { get; set; }

    public string? Segment8 { get; set; }

    public string? Segment9 { get; set; }

    public string? FormatCode { get; set; }

    public string? CfwRlvnt { get; set; }

    public string? ExchRate { get; set; }

    public string? RevalAcct { get; set; }

    public decimal? LastRevBal { get; set; }

    public DateTime? LastRevDat { get; set; }

    public string? DfltVat { get; set; }

    public string? VatChange { get; set; }

    public int? Category { get; set; }

    public string? TransCode { get; set; }

    public string? OverCode5 { get; set; }

    public string? OverCode2 { get; set; }

    public string? OverCode3 { get; set; }

    public string? OverCode4 { get; set; }

    public string? DfltTax { get; set; }

    public string? TaxPostAcc { get; set; }

    public string? AcctStrLe { get; set; }

    public string? MeaUnit { get; set; }

    public string? BalDirect { get; set; }

    public short? UserSign2 { get; set; }

    public string? PlngLevel { get; set; }

    public string? MultiLink { get; set; }

    public string? PrjRelvnt { get; set; }

    public string? Dim1Relvnt { get; set; }

    public string? Dim2Relvnt { get; set; }

    public string? Dim3Relvnt { get; set; }

    public string? Dim4Relvnt { get; set; }

    public string? Dim5Relvnt { get; set; }

    public string? AccrualTyp { get; set; }

    public string? DatevAcct { get; set; }

    public string? DatevAutoA { get; set; }

    public string? DatevFirst { get; set; }

    public int? SnapShotId { get; set; }

    public string? Pcn874rpt { get; set; }

    public string? Scadjust { get; set; }

    public int? Bplid { get; set; }

    public string? Bplname { get; set; }

    public string? SubLedgerN { get; set; }

    public string? VatregNum { get; set; }

    public string ActId { get; set; } = null!;

    public string? ClosingAcc { get; set; }

    public string? PurpCode { get; set; }

    public string? RefCode { get; set; }

    public string? BlocManPos { get; set; }

    public string? PriAccCode { get; set; }

    public string? CstAccOnly { get; set; }

    public decimal? AlloweFrom { get; set; }

    public decimal? AllowedTo { get; set; }

    public string? BalanceA { get; set; }

    public int? RmrkTmpt { get; set; }

    public string? CemRelvnt { get; set; }

    public string? CemCode { get; set; }

    public string? StdActCode { get; set; }

    public string? TaxonCode { get; set; }

    public int? InClassTyp { get; set; }

    public int? InClassCat { get; set; }

    public int? ExClassTyp { get; set; }

    public int? ExClassCat { get; set; }

    public string? UCodCuentaSii { get; set; }

    public string? UDescCuentaSii { get; set; }

    public string? UCodAntiguo { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }

    public int? ULinea { get; set; }

    public string? UNivel { get; set; }
}
