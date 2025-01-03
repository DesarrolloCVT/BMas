using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Flcconf
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UPathLogo { get; set; }

    public string? USmtpserver { get; set; }

    public int? UPort { get; set; }

    public short? UUsing { get; set; }

    public short? UAuth { get; set; }

    public string? USenduser { get; set; }

    public string? USendpwd { get; set; }

    public string? UMailfrom { get; set; }

    public string? UNvxLine { get; set; }

    public string? UOcxLine { get; set; }

    public string? UAnpxLine { get; set; }

    public string? UAncxLine { get; set; }

    public string? UTcdia { get; set; }

    public short? UP0d { get; set; }

    public short? UP0h { get; set; }

    public short? UP1d { get; set; }

    public short? UP1h { get; set; }

    public short? UP2d { get; set; }

    public short? UP2h { get; set; }

    public short? UP3d { get; set; }

    public short? UP3h { get; set; }

    public short? UP4d { get; set; }

    public short? UP4h { get; set; }

    public short? UP5d { get; set; }

    public short? UP5h { get; set; }

    public short? UP6d { get; set; }

    public short? UP6h { get; set; }

    public short? UP7d { get; set; }

    public short? UP7h { get; set; }

    public short? US2d { get; set; }

    public short? US2h { get; set; }

    public short? US3d { get; set; }

    public short? US3h { get; set; }

    public short? US4d { get; set; }

    public short? US4h { get; set; }

    public short? USmd { get; set; }

    public short? USmh { get; set; }

    public string? UExtCp { get; set; }

    public string? UUseBldate { get; set; }
}
