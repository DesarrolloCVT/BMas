using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dal1
{
    public int AbsEntry { get; set; }

    public int? LinkEntry { get; set; }

    public string? ItemId { get; set; }

    public string? ObjName { get; set; }

    public string? PropName { get; set; }

    public string? QueryCol { get; set; }

    public string? MobDesc { get; set; }

    public string? IsUdf { get; set; }
}
