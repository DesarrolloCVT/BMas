using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Omsn
{
    public int AbsEntry { get; set; }

    public string MsnCode { get; set; } = null!;

    public string? Descr { get; set; }

    public string? GrpPeriods { get; set; }

    public int? PeriodsLen { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? MaxLdTime { get; set; }

    public string? HldaysProd { get; set; }

    public string? HldaysPurc { get; set; }

    public string? ItmFrom { get; set; }

    public string? ItmTo { get; set; }

    public int? ItmGrp { get; set; }

    public string? ItmQryGrp { get; set; }

    public string? ExistStock { get; set; }

    public string? PurchOrder { get; set; }

    public string? SalesOrder { get; set; }

    public string? WorkOrder { get; set; }

    public string? MinStckLvl { get; set; }

    public int? Fctabs { get; set; }

    public string? SortBy { get; set; }

    public string? ItmReq { get; set; }

    public string? Simulation { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? LastExecDa { get; set; }

    public string? AllItems { get; set; }

    public string? ByCompany { get; set; }

    public string? IncHisData { get; set; }

    public string? ResInv { get; set; }

    public string? Wtrq { get; set; }

    public string? InvtLevel { get; set; }

    public string? RcmPo { get; set; }

    public string? RcmWo { get; set; }

    public string? RcmWtrq { get; set; }

    public string? RcmdefWhs { get; set; }

    public string? OnlyNettbl { get; set; }

    public string? ExpandedPo { get; set; }

    public string? ExpandedSo { get; set; }

    public DateTime? RcmCalDate { get; set; }

    public int? RcmCalTime { get; set; }

    public string? PurchOat { get; set; }

    public string? SalesOat { get; set; }

    public string? Rots { get; set; }

    public string? ExpdResInv { get; set; }

    public string? ExpdWor { get; set; }

    public string? IgnoreClt { get; set; }

    public string? PurchReq { get; set; }

    public string? PurchQuota { get; set; }

    public string? SalesQuota { get; set; }

    public string? ExpdPurReq { get; set; }

    public string? ExpdPquota { get; set; }

    public string? ExpdSquota { get; set; }

    public string? ExpdPagree { get; set; }

    public string? ExpdSagree { get; set; }

    public string? ExpdTraReq { get; set; }

    public string? DisSelItem { get; set; }
}
