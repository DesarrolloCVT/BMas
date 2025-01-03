using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class ExxOrdn
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

    public string UExxPedEs { get; set; } = null!;

    public string UExxProgDes { get; set; } = null!;

    public DateTime? UExxDesDia { get; set; }

    public string? UExxDesHorario { get; set; }

    public string? UExxDesRetiro { get; set; }

    public string? UExxObjTyp { get; set; }

    public string? UExxCarCode { get; set; }

    public string? UExxCardName { get; set; }

    public string? UExxLicTradNum { get; set; }

    public string? UExxPhone1 { get; set; }

    public string? UExxMail { get; set; }

    public string? UExxAddress { get; set; }

    public string? UExxIdtienda { get; set; }

    public decimal? UExxNeto { get; set; }

    public decimal? UExxDescuentoPrc { get; set; }

    public decimal? UExxDescuento { get; set; }

    public decimal? UExxImpuesto { get; set; }

    public decimal? UExxTotalCalculado { get; set; }

    public string? UExxGenera { get; set; }

    public string UExxSuspend { get; set; } = null!;

    public string UExxAnull { get; set; } = null!;

    public string? UComments { get; set; }

    public DateTime? UDocDate { get; set; }

    public DateTime? UDocDueDate { get; set; }

    public string? UIdcaja { get; set; }

    public int? UDocEntryRefDoc { get; set; }

    public int? UDocEntryRefPay { get; set; }

    public int? UExxSlpCode { get; set; }

    public string? UDocCur { get; set; }

    public string? UShipToCode { get; set; }

    public string? UPayToCode { get; set; }
}
