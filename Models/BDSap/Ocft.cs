using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocft
{
    public int Cftid { get; set; }

    public int? Cfwid { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? SysCredit { get; set; }

    public decimal? SysDebit { get; set; }

    public decimal? Fcdebit { get; set; }

    public decimal? Fccredit { get; set; }

    public string? Fccurrency { get; set; }

    public string? Account { get; set; }

    public int? BatchNum { get; set; }

    public int? Jdtid { get; set; }

    public int? JdtlineId { get; set; }

    public string? TransType { get; set; }

    public string? BaseRef { get; set; }

    public string? PaymentMen { get; set; }

    public string? PaymentRef { get; set; }

    public DateTime? PostDate { get; set; }

    public DateTime? ValueDate { get; set; }

    public string? Status { get; set; }
}
