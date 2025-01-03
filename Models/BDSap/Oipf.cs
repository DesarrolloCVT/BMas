using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oipf
{
    public int DocEntry { get; set; }

    public int DocNum { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? DocDueDate { get; set; }

    public string? CardCode { get; set; }

    public string? SuppName { get; set; }

    public string? AgentCode { get; set; }

    public string? AgentName { get; set; }

    public string? DocStatus { get; set; }

    public string? AgentNum { get; set; }

    public string? Descr { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? DocCur { get; set; }

    public decimal? DocRate { get; set; }

    public decimal? ExpCustom { get; set; }

    public decimal? ActCustom { get; set; }

    public decimal? Vat1 { get; set; }

    public decimal? Vat2 { get; set; }

    public decimal? BeforeVat { get; set; }

    public decimal? DocTotal { get; set; }

    public decimal? CostSum { get; set; }

    public short? DocTime { get; set; }

    public string? Canceled { get; set; }

    public decimal? ExCustomFc { get; set; }

    public decimal? AcCustomFc { get; set; }

    public decimal? Vat1Fc { get; set; }

    public decimal? Vat2Fc { get; set; }

    public decimal? BeforVatFc { get; set; }

    public decimal? DocTotalFc { get; set; }

    public decimal? CostSumFc { get; set; }

    public DateTime? CloseDate { get; set; }

    public decimal? CostMatch { get; set; }

    public decimal? CMatchFc { get; set; }

    public string? BillOfLad { get; set; }

    public short? TrnspCode { get; set; }

    public decimal? CostFactor { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Transfered { get; set; }

    public short Instance { get; set; }

    public DateTime? TaxDate { get; set; }

    public int Series { get; set; }

    public int? JdtNum { get; set; }

    public string? JdtMemo { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? ObjType { get; set; }

    public decimal? ExCustomSc { get; set; }

    public decimal? ActCustSc { get; set; }

    public decimal? TtlCostSc { get; set; }

    public string? VersionNum { get; set; }

    public string? OpenForLaC { get; set; }

    public string? IncCustom { get; set; }

    public short? SeqCode { get; set; }

    public int? Serial { get; set; }

    public string? SeriesStr { get; set; }

    public string? SubStr { get; set; }

    public string? BuildDesc { get; set; }

    public string? SupplCode { get; set; }

    public int? AtcEntry { get; set; }

    public DateTime? CustDate { get; set; }

    public int? Bplid { get; set; }

    public string? Dppstatus { get; set; }

    public string? EncryptIv { get; set; }
}
