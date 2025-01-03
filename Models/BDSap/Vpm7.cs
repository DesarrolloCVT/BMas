using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Vpm7
{
    public int DocNum { get; set; }

    public int LineSeq { get; set; }

    public int? InvoiceSeq { get; set; }

    public DateTime? ValueDate { get; set; }

    public int? Inv4Seq { get; set; }

    public decimal? TaxSum { get; set; }

    public decimal? TaxSumFrgn { get; set; }

    public decimal? TaxSumSys { get; set; }

    public decimal? BaseSum { get; set; }

    public decimal? BaseSumFrg { get; set; }

    public decimal? BaseSumSys { get; set; }

    public string? ObjectType { get; set; }

    public int? LogInstanc { get; set; }

    public string? EncryptIv { get; set; }
}
