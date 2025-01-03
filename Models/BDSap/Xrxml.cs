using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Xrxml
{
    public string XmlId { get; set; } = null!;

    public string? Xml { get; set; }

    public int Global { get; set; }
}
