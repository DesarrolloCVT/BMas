﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Iwb1
{
    public int AbsEntry { get; set; }

    public int LineNumber { get; set; }

    public int? BtqAbs { get; set; }

    public int? MdAbsEntry { get; set; }

    public decimal? CountedQty { get; set; }
}