using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wpk3
{
    public int AbsEntry { get; set; }

    public int? DsbrdEntry { get; set; }

    public string? FldName { get; set; }

    public string? FldMethod { get; set; }

    public string? DbType { get; set; }

    public int? SqlType { get; set; }
}
