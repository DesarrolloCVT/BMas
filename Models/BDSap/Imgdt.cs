using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Imgdt
{
    public int Id { get; set; }

    public string? Owner { get; set; }

    public int? GrpId { get; set; }

    public DateTime? Time { get; set; }
}
