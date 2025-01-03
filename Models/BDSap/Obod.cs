using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obod
{
    public int BiodEntry { get; set; }

    public short? BiodUid { get; set; }

    public int? BiodQid { get; set; }

    public string? BiodQn { get; set; }

    public DateTime? BiodQld { get; set; }

    public short? BiodQlt { get; set; }
}
