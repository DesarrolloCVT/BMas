using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otiz
{
    public int Id { get; set; }

    public string? ChangeDate { get; set; }

    public int? TimeZone { get; set; }

    public string? ActiveDst { get; set; }

    public int? Offset { get; set; }
}
