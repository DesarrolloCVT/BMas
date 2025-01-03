using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obst
{
    public int AbsEntry { get; set; }

    public decimal Amount { get; set; }

    public decimal? StampTax { get; set; }
}
