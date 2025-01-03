using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oaob
{
    public int AlertCode { get; set; }

    public DateTime? SendDate { get; set; }

    public short? SendTime { get; set; }

    public string? WasSent { get; set; }

    public short UserSign { get; set; }
}
