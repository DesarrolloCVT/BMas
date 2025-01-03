using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rcr2
{
    public string RcurCode { get; set; } = null!;

    public int? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public int LineNum { get; set; }

    public int? RefDocEntr { get; set; }

    public int? RefDocNum { get; set; }

    public string? ExtDocNum { get; set; }

    public string? RefObjType { get; set; }

    public DateTime? IssueDate { get; set; }

    public string? Remark { get; set; }

    public string? CardCode { get; set; }

    public short Instance { get; set; }
}
