using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owvt
{
    public string Guid { get; set; } = null!;

    public int? Order { get; set; }

    public int? UserId { get; set; }

    public string? ViewType { get; set; }

    public string? SubVtype { get; set; }

    public string? ViewId { get; set; }

    public string? ObjName { get; set; }

    public string? FltBarLout { get; set; }

    public string? SysFilter { get; set; }

    public string? UserFilter { get; set; }

    public string? CdtFilter { get; set; }

    public string? IsPublic { get; set; }

    public string? IsSys { get; set; }

    public string? Name { get; set; }

    public int? Version { get; set; }

    public string? OvpCus { get; set; }

    public string? ChartCus { get; set; }
}
