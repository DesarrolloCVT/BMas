using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rDocupendiente
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

    public string? UIdtienda { get; set; }

    public string? UIdcaja { get; set; }

    public string? UIdcajaHisto { get; set; }

    public string? UErrorCodigo { get; set; }

    public string? UErrorMensaje { get; set; }

    public decimal? UBaseEntry { get; set; }

    public decimal? UBaseType { get; set; }

    public decimal? UBaseTotal { get; set; }

    public decimal? UObjectType { get; set; }

    public decimal? UObjectTotal { get; set; }

    public string? UEstado { get; set; }

    public string? UErrorEstadoCodigo { get; set; }

    public string? UErrorEstadoMensaje { get; set; }

    public string? UXml { get; set; }
}
