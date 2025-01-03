using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocrh
{
    public int AbsId { get; set; }

    public short? CreditCard { get; set; }

    public string? CrdCardNum { get; set; }

    public DateTime? CardValid { get; set; }

    public string? VoucherNum { get; set; }

    public string? OwnerIdNum { get; set; }

    public string? OwnerPhone { get; set; }

    public short? CrTypeCode { get; set; }

    public short? NumOfPmnts { get; set; }

    public DateTime? PayDate { get; set; }

    public decimal? FirstSum { get; set; }

    public decimal? AddPmntSum { get; set; }

    public decimal? CreditSum { get; set; }

    public string? CreditCurr { get; set; }

    public decimal? CreditRate { get; set; }

    public string? ConfNum { get; set; }

    public string? CreditType { get; set; }

    public string? CreditDps { get; set; }

    public string? Deposited { get; set; }

    public DateTime? DeposDate { get; set; }

    public int? RctAbs { get; set; }

    public int? DepNum { get; set; }

    public string? AcctCode { get; set; }

    public string? CreditAcct { get; set; }

    public string? CardCode { get; set; }

    public string? Canceled { get; set; }

    public string? Storno { get; set; }

    public int? RcptLineId { get; set; }

    public decimal? Recived { get; set; }

    public string? Converted { get; set; }

    public string? ConvertTo { get; set; }

    public string? Transfered { get; set; }

    public short Instance { get; set; }

    public short? UserSign { get; set; }

    public string? TransRef { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? ConsolNum { get; set; }

    public string? Project { get; set; }

    public string? CardName { get; set; }

    public string? EnOwnerId { get; set; }

    public string? EncryptIv { get; set; }
}
