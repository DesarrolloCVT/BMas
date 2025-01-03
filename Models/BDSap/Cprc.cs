using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cprc
{
    public int CntctCode { get; set; }

    public int CommMeanId { get; set; }

    public string? Select { get; set; }

    public string? CardCode { get; set; }

    public string? CntctName { get; set; }
}
