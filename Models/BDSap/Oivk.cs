using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oivk
{
    public int TransSeq { get; set; }

    public int LayerId { get; set; }

    public int? RootId { get; set; }

    public int? TransNum { get; set; }

    public int? Instance { get; set; }

    public int InmtransSe { get; set; }
}
