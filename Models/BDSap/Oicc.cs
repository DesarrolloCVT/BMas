﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oicc
{
    public int AbsEntry { get; set; }

    public string Code { get; set; } = null!;

    public string? Descriptio { get; set; }
}