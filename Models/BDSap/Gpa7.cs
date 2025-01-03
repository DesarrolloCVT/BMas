using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gpa7
{
    public int AbsEntry { get; set; }

    public DateTime? PostDate { get; set; }

    public DateTime? DocDate { get; set; }

    public int? Series { get; set; }

    public string? Ref2 { get; set; }

    public string? Jeremarks { get; set; }

    public string? Mrvref { get; set; }
}
