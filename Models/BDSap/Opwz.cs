using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opwz
{
    public int IdNumber { get; set; }

    public DateTime? PmntDate { get; set; }

    public DateTime? NextDate { get; set; }

    public string? OutgoType { get; set; }

    public string? IncomType { get; set; }

    public string? CheckPmntM { get; set; }

    public string? BnkTrnsPmM { get; set; }

    public string? FilePath { get; set; }

    public DateTime? PostDtFrom { get; set; }

    public DateTime? PostDtTo { get; set; }

    public DateTime? ValDteFrom { get; set; }

    public DateTime? ValDateTo { get; set; }

    public decimal? ApInvAmntF { get; set; }

    public decimal? ApInvAmntT { get; set; }

    public int? PchNoFrom { get; set; }

    public int? PchNoTo { get; set; }

    public int? InvNoFrom { get; set; }

    public int? InvNoTo { get; set; }

    public int? SelPriorit { get; set; }

    public string? Status { get; set; }

    public string WizardName { get; set; } = null!;

    public string? StatusDisc { get; set; }

    public string? Canceled { get; set; }

    public string? BoePmnMn { get; set; }

    public int? SeriesOut { get; set; }

    public int? SeriesIn { get; set; }

    public decimal? TotalOut { get; set; }

    public decimal? TotalIn { get; set; }

    public string? ViewIntBal { get; set; }

    public string? SelMthd { get; set; }

    public int? MinumFrom { get; set; }

    public int? MinumTo { get; set; }

    public DateTime? MidateFrom { get; set; }

    public DateTime? MidateTo { get; set; }

    public int? MivnumFrom { get; set; }

    public int? MivnumTo { get; set; }

    public DateTime? MivdateFro { get; set; }

    public DateTime? MivdateTo { get; set; }

    public DateTime? ApdocDtFrm { get; set; }

    public DateTime? ApdocDtTo { get; set; }

    public DateTime? ApdueDtFrm { get; set; }

    public DateTime? NxtPmntDat { get; set; }

    public decimal? MinPayAr { get; set; }

    public decimal? MinPayAp { get; set; }

    public string? ShowAtCard { get; set; }

    public short? TolerDays { get; set; }

    public decimal? MinCashDis { get; set; }

    public string? NegBalBp { get; set; }

    public string? ManualJe { get; set; }

    public string? NegTrans { get; set; }

    public string? CdtransApp { get; set; }

    public short? UserSign { get; set; }

    public int? CigTo { get; set; }

    public int? CupFrom { get; set; }

    public int? CupTo { get; set; }

    public int? CigFrom { get; set; }

    public int? Bplid { get; set; }

    public DateTime? BoeDdfrom { get; set; }

    public DateTime? BoeDdto { get; set; }

    public int? BoeNumFrom { get; set; }

    public int? BoeNumTo { get; set; }

    public string? BoeStatus { get; set; }

    public string? HaExistBoe { get; set; }

    public int? SeriesPoo { get; set; }

    public int? SeriesPoi { get; set; }

    public string? SeqType { get; set; }

    public string? PayDueDate { get; set; }

    public string? CentrPay { get; set; }

    public int? BaApFrom { get; set; }

    public int? BaApTo { get; set; }

    public int? BaArFrom { get; set; }

    public int? BaArTo { get; set; }

    public int? JobId { get; set; }

    public string? ZeroBalBp { get; set; }

    public string? ZeroBalDoc { get; set; }
}
