using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ochh
{
    public int CheckKey { get; set; }

    public int? CheckNum { get; set; }

    public string? BankCode { get; set; }

    public string? Branch { get; set; }

    public string? CashCheck { get; set; }

    public DateTime? CheckDate { get; set; }

    public string? Details { get; set; }

    public string? CardCode { get; set; }

    public DateTime? RcptDate { get; set; }

    public int? RcptNum { get; set; }

    public decimal? CheckSum { get; set; }

    public string? Trnsfrable { get; set; }

    public string? Deposited { get; set; }

    public string? Converted { get; set; }

    public string? Vendor { get; set; }

    public int? TransNum { get; set; }

    public int? DepNum2 { get; set; }

    public int? DpstAbs { get; set; }

    public string? BankAcct { get; set; }

    public string? AcctNum { get; set; }

    public string? Currency { get; set; }

    public string? Canceled { get; set; }

    public int? RcptLineId { get; set; }

    public string? Transfered { get; set; }

    public short? Instance { get; set; }

    public short? UserId { get; set; }

    public string? BankCountr { get; set; }

    public string? Project { get; set; }

    public int? CanceJeabs { get; set; }

    public int? TempJeabs { get; set; }

    public string? CardName { get; set; }

    public string? FiscalId { get; set; }

    public string? OrigIssdBy { get; set; }

    public string? RejeByBank { get; set; }

    public string? EnAcctNum { get; set; }

    public string? EncryptIv { get; set; }

    public string? Dppstatus { get; set; }
}
