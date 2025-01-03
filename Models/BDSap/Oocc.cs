using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oocc
{
    public int AbsEntry { get; set; }

    public string Code { get; set; } = null!;

    public string? Dscription { get; set; }

    public string? Note { get; set; }

    public string? ReqBoeSt { get; set; }

    public string IsMovement { get; set; } = null!;
}
