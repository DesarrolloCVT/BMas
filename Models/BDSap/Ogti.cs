using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ogti
{
    public int AbsEntry { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? MappingNum { get; set; }

    public string? Voiding { get; set; }

    public string? ItemList { get; set; }

    public string? CategNum { get; set; }

    public string? GtsInvNum { get; set; }

    public int? ItemRowNum { get; set; }

    public DateTime? DocDate { get; set; }

    public short? FiscaMonth { get; set; }

    public decimal? DocAmount { get; set; }

    public decimal? VatPercent { get; set; }

    public decimal? VatAmount { get; set; }

    public string? BpName { get; set; }

    public string? BpTaxRgNum { get; set; }

    public string? BpAddrTel { get; set; }

    public string? BpBankNum { get; set; }

    public string? SellerName { get; set; }

    public string? SelTaxReg { get; set; }

    public string? SelAddTel { get; set; }

    public string? SelBankAct { get; set; }

    public string? Remarks { get; set; }

    public string? Issuer { get; set; }

    public string? Checker { get; set; }

    public string? Payee { get; set; }

    public string? InBndFile { get; set; }
}
