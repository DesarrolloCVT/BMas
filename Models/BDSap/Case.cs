using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Case
{
    public int AbsEntry { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public short? UserSign { get; set; }

    public string? Message { get; set; }
}
