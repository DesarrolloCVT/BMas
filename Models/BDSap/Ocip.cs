using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocip
{
    public int AbsEntry { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public int? DsplId { get; set; }

    public string? IsEnable { get; set; }
}
