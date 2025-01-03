using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Arc3
{
    public int DocNum { get; set; }

    public int LineId { get; set; }

    public short? CreditCard { get; set; }

    public string? CreditAcct { get; set; }

    public string? CrCardNum { get; set; }

    public DateTime? CardValid { get; set; }

    public string? VoucherNum { get; set; }

    public string? OwnerIdNum { get; set; }

    public string? OwnerPhone { get; set; }

    public short? CrTypeCode { get; set; }

    public short? NumOfPmnts { get; set; }

    public DateTime? FirstDue { get; set; }

    public decimal? FirstSum { get; set; }

    public decimal? AddPmntSum { get; set; }

    public decimal? CreditSum { get; set; }

    public string? CreditCur { get; set; }

    public decimal? CreditRate { get; set; }

    public string? ConfNum { get; set; }

    public string? CreditType { get; set; }

    public short? CredPmnts { get; set; }

    public string? PlCrdStat { get; set; }

    public string? MagnetStr { get; set; }

    public string? SpiltCred { get; set; }

    public int? ConsolNum { get; set; }

    public string ObjType { get; set; } = null!;

    public int LogInstanc { get; set; }

    public string? EncryptIv { get; set; }

    public string? EnOwnerId { get; set; }

    public string? UX4rPayproid { get; set; }
}
