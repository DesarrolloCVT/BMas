using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orcn
{
    public int ChainCode { get; set; }

    public string ChainName { get; set; } = null!;

    public string? SuppNum { get; set; }

    public string? SuppName { get; set; }

    public string? Locked { get; set; }

    public string? SavePath { get; set; }

    public string? UsePartSup { get; set; }

    public int? BaseCode { get; set; }

    public string? DataSource { get; set; }

    public int? ExportNum { get; set; }

    public short? UserSign { get; set; }
}
