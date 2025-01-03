using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aec4
{
    public int AbsEntry { get; set; }

    public string? Code { get; set; }

    public int? LineNum { get; set; }

    public string? ObjType { get; set; }

    public string? ObjXpath { get; set; }

    public string? FieldType { get; set; }

    public string? FieldXpath { get; set; }

    public int? ImportFmt { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short LogInstanc { get; set; }

    public int? DflDserie { get; set; }
}
