using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dsc1
{
    public string BankCode { get; set; } = null!;

    public string Account { get; set; } = null!;

    public string? Branch { get; set; }

    public int? NextCheck { get; set; }

    public string? Glaccount { get; set; }

    public string? Free { get; set; }

    public string? Street { get; set; }

    public string? Block { get; set; }

    public string? ZipCode { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string Country { get; set; } = null!;

    public string? State { get; set; }

    public string? Bisr { get; set; }

    public string? ControlKey { get; set; }

    public string? UsrNumber1 { get; set; }

    public string? UsrNumber2 { get; set; }

    public string? UsrNumber3 { get; set; }

    public string? UsrNumber4 { get; set; }

    public string? Iban { get; set; }

    public string? DscountBoe { get; set; }

    public int? TolrnceDay { get; set; }

    public decimal? MinAmntBoe { get; set; }

    public decimal? MaxAmntBoe { get; set; }

    public decimal? DscntLimit { get; set; }

    public int? DaysInAdva { get; set; }

    public string? BankCollec { get; set; }

    public string? BankDiscou { get; set; }

    public string? BranchName { get; set; }

    public string? AliasName { get; set; }

    public string? CompanyCod { get; set; }

    public string? AcctType { get; set; }

    public string? Building { get; set; }

    public string? Bik { get; set; }

    public string? AcctName { get; set; }

    public string? CorresAcct { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? GlintriAct { get; set; }

    public string? ChkPaper { get; set; }

    public short? MaxChkLine { get; set; }

    public string? TmpltName { get; set; }

    public int AbsEntry { get; set; }

    public int? BankKey { get; set; }

    public string? LockChk { get; set; }

    public int? OurNum { get; set; }

    public string? AgreeNum { get; set; }

    public string? AccountChk { get; set; }

    public short? Isrtype { get; set; }

    public string? IsrbillerI { get; set; }

    public string? CustIdNum { get; set; }

    public int? InSeri { get; set; }

    public int? OutSeri { get; set; }

    public int? Jdtseri { get; set; }

    public string? FilePlug { get; set; }

    public string? ImpStmt { get; set; }

    public string? PreNumber { get; set; }

    public string? AddrType { get; set; }

    public string? StreetNo { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UsrLogSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? SwiftNum { get; set; }

    public string? FineAcct { get; set; }

    public string? IntrstAcct { get; set; }

    public string? DscntAcct { get; set; }

    public string? SvcFeeAcct { get; set; }

    public string? BranchChk { get; set; }

    public string? RetFile { get; set; }

    public string? IoftaxAcct { get; set; }

    public string? OthExpAcct { get; set; }

    public string? OthIncAcct { get; set; }

    public string? CollCode { get; set; }

    public int? FileSeqNno { get; set; }

    public string? RefCoLevel { get; set; }

    public short? RefFixLen1 { get; set; }

    public short? RefFixLen2 { get; set; }

    public string? Currency { get; set; }

    public string? NoValidBal { get; set; }

    public string? Echeck { get; set; }
}
