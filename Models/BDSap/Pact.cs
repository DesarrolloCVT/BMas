using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pact
{
    public int AbsEntry { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? TgtObjId { get; set; }

    public string? SrcObjId { get; set; }

    public string? SrcType { get; set; }
}
