using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oagm
{
    public int DocEntry { get; set; }

    public string ObjType { get; set; } = null!;

    public string? XmlGen { get; set; }

    public string? XmlRet { get; set; }

    public string? Message { get; set; }
}
