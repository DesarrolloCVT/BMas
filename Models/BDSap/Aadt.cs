using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aadt
{
    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public string? BalanceAct { get; set; }

    public string? ClrAcqAct { get; set; }

    public string? RevResvAct { get; set; }

    public string? OrdDprAct { get; set; }

    public string? OrdDprAcc { get; set; }

    public string? UnpDprAct { get; set; }

    public string? UnpDprAcc { get; set; }

    public string? SpDprAct { get; set; }

    public string? SpDprAcc { get; set; }

    public string? SaRevNact { get; set; }

    public string? ReExpNact { get; set; }

    public string? ReRevNact { get; set; }

    public string? ReNbveAct { get; set; }

    public string? ReNbvrAct { get; set; }

    public string? ClrDscAct { get; set; }

    public string? RevReAct { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? ClearAccRe { get; set; }

    public string? RevResvClr { get; set; }

    public int? SnapshotId { get; set; }

    public string? RevAct { get; set; }

    public string? RevLossAct { get; set; }
}
