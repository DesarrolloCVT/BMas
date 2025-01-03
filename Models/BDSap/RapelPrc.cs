using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class RapelPrc
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string UCardCode { get; set; } = null!;

    public string? UShipToCode { get; set; }

    public int? UItmsGrpCod { get; set; }

    public string? UIniPeriodo { get; set; }

    public string? UFinPeriodo { get; set; }

    public decimal? UPrcRapel { get; set; }

    public string? UItemCode { get; set; }
}
