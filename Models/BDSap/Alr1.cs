using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Alr1
{
    public int Code { get; set; }

    public int LineId { get; set; }

    public string? NameFrom { get; set; }

    public string? AddrFrom { get; set; }

    public string? NameTo { get; set; }

    public string? IsSms { get; set; }

    public string? Address { get; set; }

    public string? Status { get; set; }

    public string? ObjType { get; set; }

    public string? ObjCode { get; set; }
}
