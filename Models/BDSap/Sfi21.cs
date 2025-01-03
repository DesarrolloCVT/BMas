using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sfi21
{
    public int DocEntry { get; set; }

    public string? ObjectType { get; set; }

    public int? LogInstanc { get; set; }

    public string RefType { get; set; } = null!;

    public int LineNum { get; set; }

    public int? RefDocEntr { get; set; }

    public int? RefDocNum { get; set; }

    public string? ExtDocNum { get; set; }

    public string? RefObjType { get; set; }

    public string? AccessKey { get; set; }

    public DateTime? IssueDate { get; set; }

    public string? IssuerCnpj { get; set; }

    public string? IssuerCode { get; set; }

    public string? Model { get; set; }

    public string? Series { get; set; }

    public int? Number { get; set; }

    public string? RefAccKey { get; set; }

    public decimal? RefAmount { get; set; }

    public string? SubSeries { get; set; }

    public string? Remark { get; set; }

    public string? LinkRefTyp { get; set; }
}
