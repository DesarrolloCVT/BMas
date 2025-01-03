using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aec5
{
    public int AbsEntry { get; set; }

    public int LogNum { get; set; }

    public int? DocType { get; set; }

    public int? DocAbs { get; set; }

    public int? DocNum { get; set; }

    public string? Uuid { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateTs { get; set; }

    public short LogInstanc { get; set; }

    public int? Code { get; set; }
}
