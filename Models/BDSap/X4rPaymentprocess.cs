using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rPaymentprocess
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public int DocEntry { get; set; }

    public string? Canceled { get; set; }

    public string? Object { get; set; }

    public int? LogInst { get; set; }

    public int? UserSign { get; set; }

    public string? Transfered { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UpdateTime { get; set; }

    public string? DataSource { get; set; }

    public string? UResponse { get; set; }

    public string? UEstatus { get; set; }

    public DateTime? UFechaproceso { get; set; }

    public short? UHoraproceso { get; set; }

    public DateTime? UFechaanulado { get; set; }

    public short? UHoraanulado { get; set; }

    public string? UCodaut { get; set; }

    public string? UNumope { get; set; }

    public int? UPayproidvta { get; set; }

    public int? UPayproidanu { get; set; }

    public string? UIdtienda { get; set; }

    public string? UIdcaja { get; set; }
}
