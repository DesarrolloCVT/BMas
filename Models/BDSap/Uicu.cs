using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Uicu
{
    public short Tplid { get; set; }

    public string Tplname { get; set; } = null!;

    public string? Tpldesc { get; set; }

    public short? UserId { get; set; }

    public short? Parent { get; set; }

    public string? IsTemplate { get; set; }
}
