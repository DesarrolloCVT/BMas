using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Auncl
{
    public int AbsEntry { get; set; }

    public int? Codelist { get; set; }

    public string? Code { get; set; }

    public string? Descrip { get; set; }

    public string? SchemaCode { get; set; }

    public string? SchemaDesc { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? IsDefault { get; set; }
}
