using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ogtm
{
    public int AbsEntry { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? GtsMapNum { get; set; }

    public int? InvMapEnty { get; set; }

    public int? GtsInvNum { get; set; }

    public string? BpCode { get; set; }

    public string? BpName { get; set; }

    public string? BpTaxRegNo { get; set; }

    public string? BpAddrTel { get; set; }

    public string? BpBankNum { get; set; }

    public string? Remark { get; set; }

    public string? Checker { get; set; }

    public string? Payee { get; set; }

    public decimal? DocAmount { get; set; }

    public decimal? AmtAftDsct { get; set; }

    public decimal? TaxAmount { get; set; }

    public string? GtsStatus { get; set; }

    public DateTime? ExportDate { get; set; }

    public DateTime? VoidDate { get; set; }

    public DateTime? ImportDate { get; set; }
}
