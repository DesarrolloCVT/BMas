using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Atg1
{
    public short Ctgcode { get; set; }

    public short IntsNo { get; set; }

    public short InstMonth { get; set; }

    public short InstDays { get; set; }

    public decimal? InstPrcnt { get; set; }

    public int LogInstanc { get; set; }
}
