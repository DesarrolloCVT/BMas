using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tpi4
{
    public int DocEntry { get; set; }

    public int? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public int LineNum { get; set; }

    public int? DpmObjType { get; set; }

    public int? DpmDocEntr { get; set; }

    public int? DpmDocNum { get; set; }

    public int? PmnObjType { get; set; }

    public int? PmnDocEntr { get; set; }

    public int? PmnDocNum { get; set; }

    public DateTime? PmnTaxDate { get; set; }

    public DateTime? TrsfrDate { get; set; }

    public string? TrsfrRef { get; set; }

    public decimal? DrawnSum { get; set; }

    public decimal? DrawnSumFc { get; set; }

    public decimal? DrawnSumSc { get; set; }

    public string? DocCur { get; set; }

    public decimal? Vat { get; set; }

    public decimal? VatFc { get; set; }

    public decimal? VatSc { get; set; }

    public decimal? Gross { get; set; }

    public decimal? GrossFc { get; set; }

    public decimal? GrossSc { get; set; }
}
