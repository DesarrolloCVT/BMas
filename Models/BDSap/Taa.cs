using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Taa
{
    public int Internal { get; set; }

    public string? TaxObjType { get; set; }

    public int? TaxAbsEntr { get; set; }

    public int? LineSeq { get; set; }

    public string? DocObjType { get; set; }

    public int? InvDocEntr { get; set; }

    public DateTime? DocDate { get; set; }

    public int? SrcArrType { get; set; }

    public int? SrcLineNum { get; set; }

    public string? TaxCode { get; set; }

    public string? StaCode { get; set; }

    public int? StaType { get; set; }

    public string? IsOk { get; set; }

    public string? ErrorType { get; set; }

    public string? ErrorDescr { get; set; }

    public string? IsLiable { get; set; }

    public decimal? BaseSum { get; set; }

    public decimal? Tax1Rate { get; set; }

    public decimal? TaasRate { get; set; }

    public decimal? Tax1VatSum { get; set; }

    public decimal? TaasVatSum { get; set; }
}
