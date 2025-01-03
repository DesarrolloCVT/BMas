using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oflr
{
    public int AbsId { get; set; }

    public string? FilterName { get; set; }

    public short? UserSign { get; set; }

    public string? TableName { get; set; }

    public short? VisOrder { get; set; }

    public string? StatCol { get; set; }

    public string? UnitCol { get; set; }
}
