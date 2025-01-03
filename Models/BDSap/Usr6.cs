using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Usr6
{
    public string UserCode { get; set; } = null!;

    public int Bplid { get; set; }

    public string? DigCrtPath { get; set; }

    public string? AcsDsbldBp { get; set; }

    public short? UserId { get; set; }
}
