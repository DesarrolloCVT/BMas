using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Avm1
{
    public int AbsEntry { get; set; }

    public int PropId { get; set; }

    public string? PropDesc { get; set; }

    public string? PropType { get; set; }

    public string? PropValue { get; set; }
}
