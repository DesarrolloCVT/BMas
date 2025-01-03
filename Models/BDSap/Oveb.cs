using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oveb
{
    public int AbsEntry { get; set; }

    public string CardCode { get; set; } = null!;

    public string? VersionNum { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? LogInstanc { get; set; }

    public string? DataSource { get; set; }

    public int? UpdateTs { get; set; }

    public string? Comments { get; set; }
}
