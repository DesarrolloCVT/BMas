using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ooat
{
    public int AbsId { get; set; }

    public string? BpCode { get; set; }

    public string? BpName { get; set; }

    public int? CntctCode { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? TermDate { get; set; }

    public string? Descript { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public int? Owner { get; set; }

    public string? Renewal { get; set; }

    public string? UseDiscnt { get; set; }

    public short? RemindVal { get; set; }

    public string? RemindUnit { get; set; }

    public string? Remarks { get; set; }

    public int? AtchEntry { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdtDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Cancelled { get; set; }

    public string? DataSource { get; set; }

    public string? Transfered { get; set; }

    public string? RemindFlg { get; set; }

    public string? Fulfilled { get; set; }

    public string? Attachment { get; set; }

    public decimal? SettleProb { get; set; }

    public int? UpdtTime { get; set; }

    public string? Method { get; set; }

    public short? GroupNum { get; set; }

    public short? ListNum { get; set; }

    public DateTime? SignDate { get; set; }

    public int? AmendedTo { get; set; }

    public int? Series { get; set; }

    public int Number { get; set; }

    public string? ObjType { get; set; }

    public string? Handwrtten { get; set; }

    public string Pindicator { get; set; } = null!;

    public string BpType { get; set; } = null!;

    public short Instance { get; set; }

    public string? PayMethod { get; set; }

    public string? NumAtCard { get; set; }

    public string? Bpcurr { get; set; }

    public decimal? FixedRate { get; set; }

    public short? TrnspCode { get; set; }

    public string? Project { get; set; }

    public string? PriceMode { get; set; }

    public string? WddStatus { get; set; }

    public string? FromStat { get; set; }

    public string? Dppstatus { get; set; }

    public string? Sappassprt { get; set; }

    public string? EncryptIv { get; set; }

    public string? UContratoNum { get; set; }

    public string? UPaisOrigen { get; set; }

    public string? UIncoterm { get; set; }

    public string? UCondPago { get; set; }

    public string? UTipoTransporte { get; set; }
}
