﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocdc
{
    public string Code { get; set; } = null!;

    public string? TableDesc { get; set; }

    public string? ByDate { get; set; }

    public string? Freight { get; set; }

    public string? Tax { get; set; }

    public string? VatCrctn { get; set; }

    public string? BaseDate { get; set; }
}
