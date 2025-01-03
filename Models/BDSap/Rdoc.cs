using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rdoc
{
    public string DocCode { get; set; } = null!;

    public string? DocName { get; set; }

    public string? Author { get; set; }

    public string? Notes { get; set; }

    public short? Width { get; set; }

    public short? Height { get; set; }

    public short? Lmargin { get; set; }

    public short? Rmargin { get; set; }

    public short? Tmargin { get; set; }

    public short? Bmargin { get; set; }

    public string? CanChange { get; set; }

    public string? PaperSize { get; set; }

    public string? Oreint { get; set; }

    public short? GridSize { get; set; }

    public string? GridType { get; set; }

    public string? ShowGrid { get; set; }

    public string? SnapGrid { get; set; }

    public string? Picture { get; set; }

    public string? TypeCode { get; set; }

    public string? FrgnReport { get; set; }

    public string? CanSort { get; set; }

    public string? LeaderCode { get; set; }

    public string? FollowCode { get; set; }

    public string? SwapOnScrn { get; set; }

    public string? ScreenFont { get; set; }

    public short? ScrFoffset { get; set; }

    public string? SwpInEmail { get; set; }

    public string? EmailFont { get; set; }

    public short? EmFoffset { get; set; }

    public string? Qstring { get; set; }

    public string? Qtype { get; set; }

    public int? Language { get; set; }

    public int? RobjCode { get; set; }

    public string? ExtName { get; set; }

    public string? ExtOnErr { get; set; }

    public short? NumRepArs { get; set; }

    public string? AlgnFooter { get; set; }

    public string? TimeFormat { get; set; }

    public string? DateFormat { get; set; }

    public string? DateSep { get; set; }

    public string? DecSep { get; set; }

    public string? ThousSep { get; set; }

    public string? Printer { get; set; }

    public int? NumLayPage { get; set; }

    public int? NumCopy { get; set; }

    public string? GbiSupport { get; set; }

    public string? Use1stPrtr { get; set; }

    public string? Prtr1st { get; set; }

    public string? Shading { get; set; }

    public byte[]? Template { get; set; }

    public string? Category { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? Status { get; set; }

    public string? B1version { get; set; }

    public string? Crversion { get; set; }

    public string? Local { get; set; }

    public string? UseSysPref { get; set; }

    public string? ForMobile { get; set; }

    public string? TypeDetail { get; set; }

    public string? IsImce { get; set; }

    public string? CsUrl { get; set; }

    public string? RptHash { get; set; }
}
