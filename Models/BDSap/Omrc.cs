using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Omrc
{
    public short FirmCode { get; set; }

    public string FirmName { get; set; } = null!;

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
