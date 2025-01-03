using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cdro
{
    public string ObjectId { get; set; } = null!;

    public short FieldId { get; set; }

    public string? DescStr { get; set; }

    public short? VisOrder { get; set; }

    public short UserSign { get; set; }
}
