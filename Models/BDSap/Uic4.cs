using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Uic4
{
    public short Tplid { get; set; }

    public string FormId { get; set; } = null!;

    public short UserId { get; set; }
}
