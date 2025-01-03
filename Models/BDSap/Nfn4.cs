using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Nfn4
{
    public string ObjectCode { get; set; } = null!;

    public short SeqCode { get; set; }

    public string? SeqName { get; set; }

    public int Serial { get; set; }

    public string SeriesStr { get; set; } = null!;

    public string SubStr { get; set; } = null!;

    public string? DocSubType { get; set; }

    public string Model { get; set; } = null!;

    public string CardCode { get; set; } = null!;

    public int? DocEntry { get; set; }

    public int? DocNumber { get; set; }

    public string? IsReusable { get; set; }
}
