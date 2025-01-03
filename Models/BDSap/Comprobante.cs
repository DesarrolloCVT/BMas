using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Comprobante
{
    public short? Tipo { get; set; }

    public string Account { get; set; } = null!;

    public string? FormatCode { get; set; }

    public string? AcctName { get; set; }

    public int TransId { get; set; }

    public DateTime? RefDate { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? Sysdebit { get; set; }

    public decimal? Syscredit { get; set; }

    public string? LineMemo { get; set; }

    public string? Transtype { get; set; }

    public string Libro { get; set; } = null!;
}
