using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pwz4
{
    public int IdEntry { get; set; }

    public int? PymNum { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? PymMeth { get; set; }

    public string? GlaccCode { get; set; }

    public decimal? PymAmount { get; set; }

    public decimal? PymAmntFc { get; set; }

    public string ObjType { get; set; } = null!;

    public int RctId { get; set; }

    public string? DocCurr { get; set; }

    public string? BankAccou { get; set; }

    public string? BnkDflt { get; set; }

    public string? BankCountr { get; set; }

    public int? BankActKey { get; set; }

    public string? LineType { get; set; }

    public int? ManualNum { get; set; }

    public string? TbankCode { get; set; }

    public string? TdflAccoun { get; set; }

    public string? TbankCount { get; set; }

    public string? TargetBran { get; set; }

    public decimal? BcgPmnt { get; set; }

    public decimal? BcgPmntFc { get; set; }

    public string? RecipStatu { get; set; }

    public string? BudgetId { get; set; }

    public string? Okato { get; set; }

    public string? PymReason { get; set; }

    public string? PostPeriod { get; set; }

    public string? BaseDocTyp { get; set; }

    public DateTime? BaseDocDat { get; set; }

    public string? TaxPymType { get; set; }

    public string? Oktmo { get; set; }

    public string? Iban { get; set; }

    public string? SwiftNum { get; set; }

    public string? Uipcode { get; set; }

    public string? Dppstatus { get; set; }
}
