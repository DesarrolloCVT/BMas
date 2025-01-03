using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1VatAcctView
{
    public string? SrcObjType { get; set; }

    public int SrcObjAbs { get; set; }

    public int? SrcArrType { get; set; }

    public int? SrcLineNum { get; set; }

    public int? SrcGrpNum { get; set; }

    public string? IsDeferred { get; set; }

    public string? AcctCode { get; set; }

    public int? Tax1linSeq { get; set; }
}
