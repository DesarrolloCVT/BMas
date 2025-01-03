using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otob
{
    public string VendCode { get; set; } = null!;

    public int Form1099 { get; set; }

    public string Box1099 { get; set; } = null!;

    public DateTime? PostDate { get; set; }

    public decimal? AmountLc { get; set; }

    public string? Submitted { get; set; }
}
