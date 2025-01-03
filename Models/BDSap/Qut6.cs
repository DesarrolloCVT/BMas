using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Qut6
{
    public int DocEntry { get; set; }

    public short InstlmntId { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Status { get; set; }

    public int? DunnLevel { get; set; }

    public decimal? InsTotal { get; set; }

    public decimal? InsTotalFc { get; set; }

    public decimal? InsTotalSy { get; set; }

    public decimal? PaidToDate { get; set; }

    public decimal? PaidFc { get; set; }

    public decimal? PaidSys { get; set; }

    public decimal? VatSum { get; set; }

    public decimal? VatSumFc { get; set; }

    public decimal? VatSumSy { get; set; }

    public decimal? VatPaid { get; set; }

    public decimal? VatPaidFc { get; set; }

    public decimal? VatPaidSys { get; set; }

    public decimal? TotalExpns { get; set; }

    public decimal? TotalExpFc { get; set; }

    public decimal? TotalExpSc { get; set; }

    public decimal? ExpAppl { get; set; }

    public decimal? ExpApplFc { get; set; }

    public decimal? ExpApplSc { get; set; }

    public decimal? Wtsum { get; set; }

    public decimal? WtsumFc { get; set; }

    public decimal? WtsumSc { get; set; }

    public decimal? Wtapplied { get; set; }

    public decimal? WtappliedF { get; set; }

    public decimal? WtappliedS { get; set; }

    public decimal? TotalBlck { get; set; }

    public decimal? TotalBlckF { get; set; }

    public decimal? TotalBlckS { get; set; }

    public decimal? Vatblck { get; set; }

    public decimal? VatblckFc { get; set; }

    public decimal? VatblckSc { get; set; }

    public decimal? ExpnsBlck { get; set; }

    public decimal? ExpnsBlckF { get; set; }

    public decimal? ExpnsBlckS { get; set; }

    public decimal? Wtblocked { get; set; }

    public decimal? WtblockedF { get; set; }

    public decimal? WtblockedS { get; set; }

    public decimal? InstPrcnt { get; set; }

    public string? DunWizBlck { get; set; }

    public DateTime? DunDate { get; set; }

    public decimal? Paid { get; set; }

    public decimal? PaidFrgn { get; set; }

    public decimal? PaidSc { get; set; }

    public string? Reserved { get; set; }

    public decimal? TaxOnExp { get; set; }

    public decimal? TaxOnExpFc { get; set; }

    public decimal? TaxOnExpSc { get; set; }

    public decimal? TaxOnExpAp { get; set; }

    public decimal? TaxOnExApF { get; set; }

    public decimal? TaxOnExApS { get; set; }

    public decimal? TaxOnExBlo { get; set; }

    public decimal? TaxOnExBlF { get; set; }

    public decimal? TaxOnExBlS { get; set; }

    public DateTime? LvlUpdDate { get; set; }

    public string? Ordered { get; set; }

    public decimal? PaidDpm { get; set; }

    public decimal? PaidDpmFc { get; set; }

    public decimal? PaidDpmSc { get; set; }

    public string? EncryptIv { get; set; }
}
