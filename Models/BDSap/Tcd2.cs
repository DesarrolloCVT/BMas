using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tcd2
{
    public int AbsId { get; set; }

    public int Tcd1Id { get; set; }

    public int DispOrder { get; set; }

    public string? KeyFld1V { get; set; }

    public string? KeyFld2V { get; set; }

    public string? KeyFld3V { get; set; }

    public string? KeyFld4V { get; set; }

    public string? KeyFld5V { get; set; }
}
