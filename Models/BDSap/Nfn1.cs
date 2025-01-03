using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Nfn1
{
    public string ObjectCode { get; set; } = null!;

    public short SeqCode { get; set; }

    public string SeqName { get; set; } = null!;

    public int? InitialNum { get; set; }

    public int? NextNum { get; set; }

    public int? LastNum { get; set; }

    public string? SeriesStr { get; set; }

    public string? SubStr { get; set; }

    public string? Remark { get; set; }

    public short? GroupCode { get; set; }

    public string? Locked { get; set; }

    public string? YearTransf { get; set; }

    public string? Indicator { get; set; }

    public string? Template { get; set; }

    public int? NumSize { get; set; }

    public string? Prefix { get; set; }

    public string? Suffix { get; set; }

    public string DocSubType { get; set; } = null!;

    public string? Model { get; set; }

    public int? Location { get; set; }

    public int Bplid { get; set; }

    public string? IsDigital { get; set; }

    public int? EnvTypeNfe { get; set; }
}
