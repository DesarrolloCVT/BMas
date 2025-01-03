using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1DocLinkedDownpaymentsView
{
    public string? ObjType { get; set; }

    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int LineSeq { get; set; }

    public int ArrayType { get; set; }

    public int? LinkedObjType { get; set; }

    public int? LinkedDocEntry { get; set; }

    public string? VatGroup { get; set; }

    public string? TaxCode { get; set; }

    public string? IsLinkedDpmposted { get; set; }
}
