﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cdc1
{
    public string CdcCode { get; set; } = null!;

    public int LineId { get; set; }

    public short? NumOfDays { get; set; }

    public decimal? Discount { get; set; }

    public short? Day { get; set; }

    public short? Month { get; set; }
}
