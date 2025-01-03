using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Adnf
{
    public int AbsEntry { get; set; }

    public int Ncmentry { get; set; }

    public string Dnfcode { get; set; } = null!;

    public string? DnfuoM { get; set; }

    public decimal? Dnffactor { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
