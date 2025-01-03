using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class AposVoucher
{
    public int DocEntry { get; set; }

    public int? DocNum { get; set; }

    public int? Period { get; set; }

    public short? Instance { get; set; }

    public int? Series { get; set; }

    public string? Handwrtten { get; set; }

    public string? Canceled { get; set; }

    public string? Object { get; set; }

    public int LogInst { get; set; }

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

    public string? UCodTienda { get; set; }

    public string? UCodCaja { get; set; }

    public string? UCodCajaCab { get; set; }

    public string? UCodCajaCabhis { get; set; }

    public DateTime? UFechaMov { get; set; }

    public string? UTipoMov { get; set; }

    public string? UUserMovi { get; set; }

    public string? UCodCausa { get; set; }

    public string? UMoneda { get; set; }

    public string? UDescrMovi { get; set; }

    public decimal? UImporte { get; set; }

    public string? UIdAsiento { get; set; }
}
