using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opym
{
    public string PayMethCod { get; set; } = null!;

    public string? Descript { get; set; }

    public string? Type { get; set; }

    public string? BankTransf { get; set; }

    public string? Address { get; set; }

    public string? BankDet { get; set; }

    public string? CllctAutor { get; set; }

    public string? FrgnPmntBl { get; set; }

    public string? FrgnBnkBl { get; set; }

    public string? CurrRestr { get; set; }

    public string? PostOffBnk { get; set; }

    public decimal? MinAmount { get; set; }

    public decimal? MaxAmount { get; set; }

    public string? BnkDflt { get; set; }

    public short? UserSign { get; set; }

    public string? DataSource { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? BankCountr { get; set; }

    public string? DflAccount { get; set; }

    public string? Glaccount { get; set; }

    public string? Branch { get; set; }

    public string? KeyCode { get; set; }

    public string? TrnsType { get; set; }

    public string? Format { get; set; }

    public string? AgtCollect { get; set; }

    public string? SendAccept { get; set; }

    public string? GrpByDate { get; set; }

    public string? DepNorm { get; set; }

    public string? DebitMemo { get; set; }

    public string? GroupPmRef { get; set; }

    public string? GroupInv { get; set; }

    public string? ValDateSel { get; set; }

    public short? PaymTerms { get; set; }

    public string? IntrimAcct { get; set; }

    public int? BnkActKey { get; set; }

    public string? DocType { get; set; }

    public string? Accepted { get; set; }

    public string? PtfId { get; set; }

    public string? PtfCode { get; set; }

    public string? PtfNum { get; set; }

    public string? CurCode { get; set; }

    public string? Instruct1 { get; set; }

    public string? Instruct2 { get; set; }

    public string? PaymntPlc { get; set; }

    public string? BoeDll { get; set; }

    public string? BankCtlKey { get; set; }

    public string? Active { get; set; }

    public decimal? BcgPcnt { get; set; }

    public string? GrpByCur { get; set; }

    public string? GrpByBank { get; set; }

    public string? DflIban { get; set; }

    public string? DflSwift { get; set; }

    public string? BoeReport { get; set; }

    public string? CancInstr { get; set; }

    public string? OccurCode { get; set; }

    public string? MovmntCode { get; set; }

    public string? NegPymCode { get; set; }

    public string? DirectDbt { get; set; }

    public string? IssueIndic { get; set; }

    public string? PrintSepa { get; set; }

    public string? PmntType { get; set; }

    public string? GrpByAgrNo { get; set; }

    public string? SpltPmtVat { get; set; }

    public string? UX4rInterkey { get; set; }
}
