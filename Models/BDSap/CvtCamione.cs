using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class CvtCamione
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UConductor { get; set; }

    public short? UIndCamionPropio { get; set; }

    public short? UUsaCarro { get; set; }

    public short? UEsCarro { get; set; }

    public decimal? UTara { get; set; }

    public decimal? UPesoMaximo { get; set; }

    public decimal? ULargoMaximo { get; set; }

    public decimal? UAnchoMaximo { get; set; }

    public decimal? UAltoMaximo { get; set; }

    public int? UCantPalletsPiso { get; set; }
}
