using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocdp
{
    public short ClsDateNum { get; set; }

    public string ClsDtCode { get; set; } = null!;

    public string? BsLineDate { get; set; }

    public string? DueMonth { get; set; }

    public short? ExtraMonth { get; set; }

    public short? ExtraDay { get; set; }
}
