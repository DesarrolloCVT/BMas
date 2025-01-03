using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Xrobj
{
    public string RepObjId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Descriptio { get; set; }

    public string? Creator { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public int? ObjType { get; set; }

    public string? XmlId { get; set; }

    public string? XlsId { get; set; }

    public string? VariablesI { get; set; }

    public string? Reference { get; set; }

    public int? RefType { get; set; }

    public int Global { get; set; }
}
