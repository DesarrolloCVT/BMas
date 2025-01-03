using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1DocJournalEntryView
{
    public string? TransType { get; set; }

    public int? CreatedBy { get; set; }

    public int? TransCnt { get; set; }

    public string? TransCode { get; set; }

    public int? StornoToTr { get; set; }

    public string? ResidenNum { get; set; }

    public string? OperatCode { get; set; }

    public decimal? LocTotal { get; set; }

    public decimal? FcTotal { get; set; }

    public decimal? SysTotal { get; set; }

    public string? TransCurr { get; set; }
}
