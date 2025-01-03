using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Csn1
{
    public int AbsId { get; set; }

    public short Series { get; set; }

    public string? BeginStr { get; set; }

    public int? InitialNum { get; set; }

    public int? NextNum { get; set; }

    public int? LastNum { get; set; }
}
