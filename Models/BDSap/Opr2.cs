using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opr2
{
    public int OpportId { get; set; }

    public short Line { get; set; }

    public int? ParterId { get; set; }

    public string? Memo { get; set; }

    public int? OrlCode { get; set; }

    public string? RelatCard { get; set; }

    public string? EncryptIv { get; set; }
}
