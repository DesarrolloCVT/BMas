﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ohed
{
    public int EdType { get; set; }

    public string Name { get; set; } = null!;

    public string? Descriptio { get; set; }

    public string? Locked { get; set; }
}