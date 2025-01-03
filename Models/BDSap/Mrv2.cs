using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Mrv2
{
    public int DocEntry { get; set; }

    public int BaseLine { get; set; }

    public int LineNum { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Price { get; set; }

    public decimal? LineTotal { get; set; }

    public decimal? RtoStock { get; set; }

    public decimal? RactPrice { get; set; }

    public int? InmtransNm { get; set; }

    public int? Inminst { get; set; }

    public int? InmtransTy { get; set; }

    public int? InmcreatBy { get; set; }

    public string? InmbaseRef { get; set; }

    public DateTime? InmdocDate { get; set; }

    public decimal? InmopenQty { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public int? IvltransSe { get; set; }

    public int? IvllayerId { get; set; }

    public int? InmlineNum { get; set; }

    public int? InmsubLine { get; set; }
}
