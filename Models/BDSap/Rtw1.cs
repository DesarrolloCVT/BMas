using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rtw1
{
    public int AbsEntry { get; set; }

    public string? BoeMatch { get; set; }

    public string? BoeNo { get; set; }

    public DateTime? BoeDate { get; set; }

    public DateTime? BoeDueDate { get; set; }

    public DateTime? CreditDate { get; set; }

    public string? CurrBoeSt { get; set; }

    public string? ReqBoeSt { get; set; }

    public string? Instruct1 { get; set; }

    public string? Instruct2 { get; set; }

    public string? CancelCode { get; set; }

    public short? MovmntCode { get; set; }

    public short? OccurCode { get; set; }

    public DateTime? OccurDate { get; set; }

    public string? Portfolio { get; set; }

    public int? OurNum { get; set; }

    public decimal? ValueOfT { get; set; }

    public decimal? NetAmnt { get; set; }

    public decimal? PaidAmnt { get; set; }

    public decimal? FineAmnt { get; set; }

    public decimal? IntAmnt { get; set; }

    public decimal? Discounts { get; set; }

    public decimal? ServiceFee { get; set; }

    public decimal? Ioftax { get; set; }

    public decimal? OtherCred { get; set; }

    public decimal? OtherExp { get; set; }

    public decimal? OtherInc { get; set; }

    public string? Errors { get; set; }

    public string? RefNum { get; set; }

    public string? Ref2 { get; set; }

    public string? CardName { get; set; }

    public string? BoEbpname { get; set; }

    public string? MatchCode { get; set; }

    public string? Selected { get; set; }

    public int? BoeRec { get; set; }

    public int? RetIndex { get; set; }

    public string? Filtered { get; set; }

    public string? Executed { get; set; }

    public string? Failed { get; set; }

    public string? LastRun { get; set; }

    public string? ErrorMsg { get; set; }

    public string? JetransId { get; set; }

    public string? CardCode { get; set; }

    public string? PostType { get; set; }
}
