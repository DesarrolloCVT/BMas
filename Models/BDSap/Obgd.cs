using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obgd
{
    public int BgdCode { get; set; }

    public string BgdName { get; set; } = null!;

    public decimal? BgdTotal { get; set; }

    public decimal? Month1 { get; set; }

    public decimal? Month2 { get; set; }

    public decimal? Month3 { get; set; }

    public decimal? Month4 { get; set; }

    public decimal? Month5 { get; set; }

    public decimal? Month6 { get; set; }

    public decimal? Month7 { get; set; }

    public decimal? Month8 { get; set; }

    public decimal? Month9 { get; set; }

    public decimal? Month10 { get; set; }

    public decimal? Month11 { get; set; }

    public decimal? Month12 { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
