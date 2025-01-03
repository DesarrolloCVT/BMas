using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pact1
{
    public int AbsEntry { get; set; }

    public string? SrcObjId { get; set; }

    public string? SrcType { get; set; }

    public string? TgtObjId { get; set; }

    public string? TgtType { get; set; }

    public string? ActEntry { get; set; }
}
