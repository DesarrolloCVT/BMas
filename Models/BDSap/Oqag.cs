﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oqag
{
    public int Authgrpid { get; set; }

    public string Authgrpcd { get; set; } = null!;

    public string Authgrpn { get; set; } = null!;

    public int? LogInstanc { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Deleted { get; set; }

    public int? SnapShotId { get; set; }
}