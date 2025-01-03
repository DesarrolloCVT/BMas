using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rCaja1
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

    public string? UX4rMoneda { get; set; }

    public decimal? UX4rValorAper { get; set; }

    public decimal? UX4rValorAler { get; set; }

    public decimal? UX4rValorBloq { get; set; }

    public string? UX4rPorcentaje { get; set; }

    public string? UX4rCodTienda { get; set; }

    public string? UX4rCodCaja { get; set; }

    public decimal? UX4rValorMin { get; set; }

    public decimal? UX4rValorMax { get; set; }
}
