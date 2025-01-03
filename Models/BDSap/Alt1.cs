using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Alt1
{
    public int Code { get; set; }

    public short UserSign { get; set; }

    public string? SendIntrnl { get; set; }

    public string? SendEmail { get; set; }

    public string? SendSms { get; set; }

    public string? SendFax { get; set; }
}
