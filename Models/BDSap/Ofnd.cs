using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofnd
{
    public int AbsEntry { get; set; }

    public string ObjectCode { get; set; } = null!;

    public string DocSubtype { get; set; } = null!;
}
