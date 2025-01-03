using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owtum
{
    public int AbsEntry { get; set; }

    public string CardCode { get; set; } = null!;

    public DateTime PmntDate { get; set; }

    public int WttypeId { get; set; }

    public decimal? AccmAmnt { get; set; }

    public decimal? AccmAmntFc { get; set; }

    public decimal? AccmAmntSc { get; set; }

    public int Bplid { get; set; }
}
