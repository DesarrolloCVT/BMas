﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ins1
{
    public int InsId { get; set; }

    public string BpCode { get; set; } = null!;

    public int? LogInstanc { get; set; }
}