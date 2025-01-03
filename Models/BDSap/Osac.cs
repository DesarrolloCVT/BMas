using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osac
{
    public int AbsEntry { get; set; }

    public string? ServName { get; set; }

    public string ServCode { get; set; } = null!;
}
