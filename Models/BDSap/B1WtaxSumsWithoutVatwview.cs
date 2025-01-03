using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1WtaxSumsWithoutVatwview
{
    public string SrcObjType { get; set; } = null!;

    public int SrcObjAbs { get; set; }

    public int? SrcArrType { get; set; }

    public int? SrcLineNum { get; set; }

    public int? SrcGrpNum { get; set; }

    public string? BaseObjTyp { get; set; }

    public int? BaseAbs { get; set; }

    public int? BaseArrTyp { get; set; }

    public int? BaseLinNum { get; set; }

    public int? BaseGrpNum { get; set; }

    public decimal? WtaxSum { get; set; }

    public decimal? WtaxSumSc { get; set; }

    public decimal? WtaxSumFc { get; set; }
}
