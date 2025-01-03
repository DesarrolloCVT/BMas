using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofpr
{
    public int AbsEntry { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime? FRefDate { get; set; }

    public DateTime? TRefDate { get; set; }

    public DateTime? FDueDate { get; set; }

    public DateTime? TDueDate { get; set; }

    public DateTime? FTaxDate { get; set; }

    public DateTime? TTaxDate { get; set; }

    public string? Free2 { get; set; }

    public string? Free3 { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int? SubNum { get; set; }

    public string? Free { get; set; }

    public string? Free1 { get; set; }

    public string? Addition { get; set; }

    public int? AddNum { get; set; }

    public string? Category { get; set; }

    public string? Indicator { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? WasStatChd { get; set; }

    public string? PeriodStat { get; set; }

    public short? UserSign2 { get; set; }
}
