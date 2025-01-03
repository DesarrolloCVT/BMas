using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Omdc
{
    public int AbsEntry { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign { get; set; }

    public string? Status { get; set; }

    public string? UpdUser { get; set; }
}
