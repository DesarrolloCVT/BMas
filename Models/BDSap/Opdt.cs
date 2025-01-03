using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opdt
{
    public int AbsEntry { get; set; }

    public string TextCode { get; set; } = null!;

    public string? Text { get; set; }
}
