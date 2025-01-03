using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cufd
{
    public string TableId { get; set; } = null!;

    public short FieldId { get; set; }

    public string AliasId { get; set; } = null!;

    public string? Descr { get; set; }

    public string? TypeId { get; set; }

    public string? EditType { get; set; }

    public short? SizeId { get; set; }

    public short? EditSize { get; set; }

    public string? Dflt { get; set; }

    public string? NotNull { get; set; }

    public string? IndexId { get; set; }

    public string? Rtable { get; set; }

    public short? Rfield { get; set; }

    public string? Action { get; set; }

    public string? Sys { get; set; }

    public DateTime? DfltDate { get; set; }

    public string? RelUdo { get; set; }

    public string? ValidRule { get; set; }

    public string? RelSo { get; set; }

    public string? RthrdPtab { get; set; }

    public string? RthrdPfld { get; set; }
}
