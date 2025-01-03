using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rPromocion
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

    public DateTime? UX4rDesdefecha { get; set; }

    public DateTime? UX4rHastafecha { get; set; }

    public short? UX4rDesdehora { get; set; }

    public short? UX4rHastahora { get; set; }

    public decimal? UX4rDesdetotal { get; set; }

    public decimal? UX4rHastatotal { get; set; }

    public decimal? UX4rDesdecant { get; set; }

    public decimal? UX4rHastacant { get; set; }

    public string? UX4rColor { get; set; }

    public string UX4rActivo { get; set; } = null!;

    public string UX4rArtmenvalor { get; set; } = null!;

    public string? UX4rTipodesc { get; set; }

    public decimal? UX4rValor { get; set; }

    public decimal? UX4rCantcompra { get; set; }

    public string UX4rSugeventa { get; set; } = null!;

    public string? UX4rTipopromocion { get; set; }
}
