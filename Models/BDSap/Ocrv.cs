using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocrv
{
    public int AbsId { get; set; }

    public int PayId { get; set; }

    public short? CreditCard { get; set; }

    public string? CrdCardNum { get; set; }

    public DateTime? CardValid { get; set; }

    public string? VoucherNum { get; set; }

    public string? OwnerIdNum { get; set; }

    public string? OwnerPhone { get; set; }

    public DateTime? PayDate { get; set; }

    public decimal? PayAmount { get; set; }

    public string? CreditCurr { get; set; }

    public decimal? CreditRate { get; set; }

    public string? Deposited { get; set; }

    public int? DepNum2 { get; set; }

    public int? DepNum { get; set; }

    public string? AcctCode { get; set; }

    public string? VouchAcct { get; set; }

    public string? CreditAcct { get; set; }

    public string? CardCode { get; set; }

    public short? CrTypeCode { get; set; }

    public short? NumOfPmnts { get; set; }

    public string? Canceled { get; set; }

    public string? Storno { get; set; }

    public string? Transfered { get; set; }

    public short Instance { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? TransRef { get; set; }

    public string? CardName { get; set; }

    public string? EnOwnerId { get; set; }

    public string? EncryptIv { get; set; }
}
