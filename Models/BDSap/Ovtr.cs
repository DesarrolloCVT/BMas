using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ovtr
{
    public int AbsEntry { get; set; }

    public string ReportName { get; set; } = null!;

    public string? RptLayout { get; set; }

    public int? FirstPrint { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? TaxDate { get; set; }

    public string? RoundSum { get; set; }

    public string? Declration { get; set; }

    public string FilterType { get; set; } = null!;

    public string? ExcludeWt { get; set; }

    public string? CustomerIn { get; set; }

    public string? VendorIn { get; set; }

    public string? Period { get; set; }

    public int? Quarter { get; set; }

    public int? Year { get; set; }

    public string? DocType { get; set; }

    public string? CreditMemo { get; set; }

    public string? DocTypeIn { get; set; }

    public int? FirstReg { get; set; }

    public string? AccountIn { get; set; }

    public string? DeferTaxIn { get; set; }

    public string? ApndxOorP { get; set; }

    public string? DispObcb { get; set; }

    public int? FromSeries { get; set; }

    public int? ToSeries { get; set; }

    public string? Canceltn { get; set; }

    public string? HideNtrans { get; set; }

    public string? SeriesIn { get; set; }

    public string? UserCode { get; set; }

    public string? FromCardCo { get; set; }

    public string? ToCardCo { get; set; }

    public int? SizeOfStru { get; set; }

    public DateTime? PostFrDate { get; set; }

    public DateTime? PostToDate { get; set; }

    public DateTime? DocFrDate { get; set; }

    public DateTime? DocToDate { get; set; }

    public string? FromDoc1Nu { get; set; }

    public string? ToDoc1Nu { get; set; }

    public string? Serie1 { get; set; }

    public string? Serie1Cb { get; set; }

    public int? Doc1Type { get; set; }

    public string? FromDoc2Nu { get; set; }

    public string? ToDoc2Nu { get; set; }

    public string? Serie2 { get; set; }

    public string? Serie2Cb { get; set; }

    public int? Doc2Type { get; set; }

    public string? FromDoc3Nu { get; set; }

    public string? ToDoc3Nu { get; set; }

    public string? Serie3 { get; set; }

    public string? Serie3Cb { get; set; }

    public int? Doc3Type { get; set; }

    public string? FromDoc4Nu { get; set; }

    public string? ToDoc4Nu { get; set; }

    public string? Serie4 { get; set; }

    public string? Serie4Cb { get; set; }

    public int? Doc4Type { get; set; }

    public string? FromDoc5Nu { get; set; }

    public string? ToDoc5Nu { get; set; }

    public string? Serie5 { get; set; }

    public string? Serie5Cb { get; set; }

    public int? Doc5Type { get; set; }

    public string? DateRbtn { get; set; }

    public string? MarkDocsIn { get; set; }

    public string? ExRate { get; set; }

    public string? ExRateDate { get; set; }

    public string? TrsPerioTp { get; set; }

    public int? TrsPerioNu { get; set; }

    public short? TrsYear { get; set; }

    public short? TrsAdjtNum { get; set; }

    public string? DateType { get; set; }

    public string? IncServDoc { get; set; }

    public string? GrpByScode { get; set; }

    public string? IncUnReDoc { get; set; }

    public string? DoYearSum { get; set; }

    public string? DefTaxOnly { get; set; }

    public string? ExcElDoc { get; set; }

    public string? QtrByMnt { get; set; }

    public string? OnlyExtnTx { get; set; }

    public string? IncludeWtr { get; set; }

    public string? FromMark { get; set; }

    public string? ToMark { get; set; }

    public DateTime? IsueFrDate { get; set; }

    public DateTime? IsueToDate { get; set; }

    public string? FromVatNo { get; set; }

    public string? ToVatNo { get; set; }

    public string? FrInvType { get; set; }

    public string? ToInvType { get; set; }
}
