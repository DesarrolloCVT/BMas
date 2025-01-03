using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocpt
{
    public int AbsEntry { get; set; }

    public short Code { get; set; }

    public string Name { get; set; } = null!;

    public string? Descr { get; set; }

    public string? IsDefault { get; set; }

    public short UserSign { get; set; }

    public string? IsPublic { get; set; }

    public string? Strategy { get; set; }

    public int? Top { get; set; }

    public int? Left { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public DateTime? Date { get; set; }

    public short? Time { get; set; }

    public string? Mnfacturer { get; set; }

    public string? Pubby { get; set; }

    public string? Disabled { get; set; }

    public string? Type { get; set; }
}
