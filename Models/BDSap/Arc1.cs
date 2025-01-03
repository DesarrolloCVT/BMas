using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Arc1
{
    public int DocNum { get; set; }

    public int LineId { get; set; }

    public DateTime? DueDate { get; set; }

    public int? CheckNum { get; set; }

    public string? BankCode { get; set; }

    public string? Branch { get; set; }

    public string? AcctNum { get; set; }

    public string? Details { get; set; }

    public string? Trnsfrable { get; set; }

    public decimal? CheckSum { get; set; }

    public string? Currency { get; set; }

    public int? Flags { get; set; }

    public string ObjType { get; set; } = null!;

    public int LogInstanc { get; set; }

    public string? CountryCod { get; set; }

    public string? CheckAct { get; set; }

    public int? CheckAbs { get; set; }

    public int? BnkActKey { get; set; }

    public string? ManualChk { get; set; }

    public string? FiscalId { get; set; }

    public string? OrigIssdBy { get; set; }

    public string? Endorse { get; set; }

    public int? EndorsChNo { get; set; }

    public string? EnAcctNum { get; set; }

    public string? EncryptIv { get; set; }

    public string? Echeck { get; set; }

    public string? UExcluir { get; set; }

    public DateTime? UNewduedate { get; set; }

    public string? UComment { get; set; }

    public string? UFactoring { get; set; }

    public string? UCodFact { get; set; }
}
