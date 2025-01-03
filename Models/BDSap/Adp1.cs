using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Adp1
{
    public string PrintId { get; set; } = null!;

    public string ObjType { get; set; } = null!;

    public short? Copies { get; set; }

    public string? PrintOnAdd { get; set; }

    public string? ExprtOnAdd { get; set; }

    public string? RoundSums { get; set; }

    public string? Remark { get; set; }

    public string? PrintSums { get; set; }

    public string? VndrNum { get; set; }

    public string? PrnDscnt { get; set; }

    public string? SplitTran1 { get; set; }

    public string? SplitTran2 { get; set; }

    public string? SplitTran3 { get; set; }

    public string? ShowBothNu { get; set; }

    public string? BaseRmrk { get; set; }

    public short? HandCopies { get; set; }

    public string? EngKbitem { get; set; }

    public string? EngKbcard { get; set; }

    public string? OrdrPicDef { get; set; }

    public string? SpltTrBoe1 { get; set; }

    public short? LineNumPpg { get; set; }

    public short? JenumPpg { get; set; }

    public string? CashPay { get; set; }

    public string? NonCashPay { get; set; }

    public decimal? MaxUopay { get; set; }

    public string? CkeckPaper { get; set; }

    public string? AllowFuPos { get; set; }

    public string? ErdOutMode { get; set; }

    public string? ErdIncMode { get; set; }

    public string? ChkDupRef { get; set; }

    public string? CpyCvref { get; set; }

    public string? BatchSerPr { get; set; }

    public string? YearTrans { get; set; }

    public short? ReconJeSer { get; set; }

    public string? ReopOrder { get; set; }

    public string? ForceReOrd { get; set; }

    public string? PrintRows { get; set; }

    public string? Orderblock { get; set; }

    public string? RecomPkg { get; set; }

    public string? Enitemcost { get; set; }

    public string? ClosePq { get; set; }

    public string? CpyPrprice { get; set; }

    public string? EnSetCost { get; set; }

    public string? DftPlchk { get; set; }

    public short? DfltPlsel { get; set; }

    public string? EmailOnAdd { get; set; }

    public string? PdfonAdd { get; set; }

    public string? EmailSbj { get; set; }

    public string? EmailBody { get; set; }

    public string? BlockWht08 { get; set; }

    public string? BlockExprt { get; set; }

    public string? BlockPrint { get; set; }

    public string? BlockMail { get; set; }

    public string? BlockToPdf { get; set; }

    public string? BlockFax { get; set; }

    public string? PoDropPrss { get; set; }

    public string? ShowCash { get; set; }

    public string? PruseBptax { get; set; }

    public string? EnblTtlEgD { get; set; }

    public string? EnblUpdUdf { get; set; }

    public string? EnblDpmTax { get; set; }

    public string? ChkRefBp { get; set; }

    public string? ChkRefYear { get; set; }

    public string? BspDpmType { get; set; }

    public string? ReopenByC { get; set; }

    public string? ForceReByC { get; set; }

    public string? OpenSnB { get; set; }
}
