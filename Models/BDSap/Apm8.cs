using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Apm8
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public decimal? PhBudget { get; set; }

    public decimal? OpenAmtAp { get; set; }

    public decimal? InvoicedAp { get; set; }

    public decimal? TotalAp { get; set; }

    public decimal? TotVarAp { get; set; }

    public decimal? VarPercAp { get; set; }

    public decimal? AccPhBudg { get; set; }

    public decimal? AccOpAmAp { get; set; }

    public decimal? AccInvAp { get; set; }

    public decimal? AccTotAp { get; set; }

    public decimal? AccTvarAp { get; set; }

    public decimal? AccVpercAp { get; set; }

    public decimal? PoPhAmt { get; set; }

    public decimal? OpenAmtAr { get; set; }

    public decimal? InvoicedAr { get; set; }

    public decimal? TotalAr { get; set; }

    public decimal? TotVarAr { get; set; }

    public decimal? VarPercAr { get; set; }

    public decimal? AccPoPhAmt { get; set; }

    public decimal? AccOpAmAr { get; set; }

    public decimal? AccInvAr { get; set; }

    public decimal? AccTotAr { get; set; }

    public decimal? AccTvarAr { get; set; }

    public decimal? AccVpercAr { get; set; }

    public decimal? ActIccost { get; set; }

    public decimal? ActRccost { get; set; }

    public decimal? ActAddCost { get; set; }

    public decimal? ActPrCost { get; set; }

    public decimal? ActBprCost { get; set; }

    public decimal? TotalVar { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? CloseDate { get; set; }

    public int? Overdue { get; set; }

    public string? Valid { get; set; }

    public int LogInstanc { get; set; }
}
