﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oadf
{
    public short Code { get; set; }

    public string Name { get; set; } = null!;

    public string? Format { get; set; }

    public short? UserSign { get; set; }

    public string? SuppBkLine { get; set; }
}