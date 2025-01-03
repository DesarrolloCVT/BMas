using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofrm
{
    public int AbsEntry { get; set; }

    public string? Name { get; set; }

    public string? Encoding { get; set; }

    public string? FilePath { get; set; }

    public string? IsSystem { get; set; }

    public string? FrmatType { get; set; }

    public byte[]? FileContnt { get; set; }

    public string? FrmatStats { get; set; }

    public string? PaymType { get; set; }

    public string? Hash { get; set; }
}
