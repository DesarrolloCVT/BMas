using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pkl1
{
    public int AbsEntry { get; set; }

    public int PickEntry { get; set; }

    public int? OrderEntry { get; set; }

    public int? OrderLine { get; set; }

    public decimal? PickQtty { get; set; }

    public string? PickStatus { get; set; }

    public decimal? RelQtty { get; set; }

    public int? LogInsac { get; set; }

    public decimal? PrevReleas { get; set; }

    public int? BaseObject { get; set; }
}
