using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sdex
{
    public int FormId { get; set; }

    public int ItemId { get; set; }

    public int ColumnId { get; set; }

    public string? BefAppl { get; set; }

    public string? AftAppl { get; set; }

    public string? BefScript { get; set; }

    public string? AftScript { get; set; }

    public short? UserSign { get; set; }
}
