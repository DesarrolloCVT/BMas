using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Mls1
{
    public int Code { get; set; }

    public int LineNum { get; set; }

    public string? ObjType { get; set; }

    public string? ObjCode { get; set; }

    public string? ObjName { get; set; }

    public string? EMail { get; set; }

    public string? PortNum { get; set; }

    public string? Fax { get; set; }
}
