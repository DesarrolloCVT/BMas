using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Zlib1
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public short? UAno { get; set; }

    public string? UCuenta { get; set; }

    public string? UAcctCode { get; set; }

    public string? UDocum { get; set; }

    public DateTime? UDt { get; set; }

    public int? USeq { get; set; }

    public string? UAnalisis { get; set; }

    public string? UAcctName { get; set; }

    public string? UPkgId { get; set; }

    public decimal? UGlDbamt { get; set; }

    public decimal? UGlCramt { get; set; }

    public decimal? UGlBalAmt { get; set; }

    public string? UItemCode { get; set; }

    public decimal? UImSaldo { get; set; }

    public decimal? UImavgCst { get; set; }

    public string? UImWhs { get; set; }

    public string? UCardCode { get; set; }

    public int? UDocNum { get; set; }

    public string? UFolPref { get; set; }

    public int? UFolioNum { get; set; }

    public DateTime? UDocDate { get; set; }

    public string? UDocType { get; set; }

    public string? UStatus { get; set; }

    public string? URefer { get; set; }

    public int? UBplid { get; set; }
}
