using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ecm1
{
    public string Code { get; set; } = null!;

    public int LineNum { get; set; }

    public short? StrIndex { get; set; }

    public int Bplid { get; set; }

    public string? ParamType { get; set; }

    public string? ParamVisib { get; set; }

    public string ParamName { get; set; } = null!;

    public string? ParamValue { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? LogInstanc { get; set; }

    public string? ParamPrms { get; set; }

    public short? Uiorder { get; set; }

    public short? Type { get; set; }
}
