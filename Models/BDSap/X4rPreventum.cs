using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rPreventum
{
    public int DocEntry { get; set; }

    public int? DocNum { get; set; }

    public int? Period { get; set; }

    public short? Instance { get; set; }

    public int? Series { get; set; }

    public string? Handwrtten { get; set; }

    public string? Canceled { get; set; }

    public string? Object { get; set; }

    public int? LogInst { get; set; }

    public int? UserSign { get; set; }

    public string? Transfered { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UpdateTime { get; set; }

    public string? DataSource { get; set; }

    public string? RequestStatus { get; set; }

    public string? Creator { get; set; }

    public string? Remark { get; set; }

    public DateTime? UDocDate { get; set; }

    public DateTime? UDocDueDate { get; set; }

    public string? UCardCode { get; set; }

    public string? UCardName { get; set; }

    public decimal? UDiscPrcnt { get; set; }

    public decimal? UDocTotal { get; set; }

    public decimal? UVatSum { get; set; }

    public decimal? UDiscSum { get; set; }

    public string? UIdtienda { get; set; }

    public string? UIdcaja { get; set; }

    public DateTime? UX4rFechadespacho { get; set; }

    public string? UX4rHorariodespacho { get; set; }

    public string? UX4rTipodespacho { get; set; }

    public decimal? UX4rNeto { get; set; }

    public string? UX4rCreado { get; set; }

    public string? UX4rSuspendido { get; set; }

    public string? UX4rAnulado { get; set; }

    public string UProgDes { get; set; } = null!;

    public string? UObjTyp { get; set; }

    public string? UComments { get; set; }

    public int? UDocEntryRefDoc { get; set; }

    public int? UDocEntryRefPay { get; set; }

    public int? USlpCode { get; set; }
}
