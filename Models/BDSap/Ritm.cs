using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ritm
{
    public string DocCode { get; set; } = null!;

    public short ItemId { get; set; }

    public short? Container { get; set; }

    public short? Type { get; set; }

    public string? Visible { get; set; }

    public string? SupZeros { get; set; }

    public short? ItemLeft { get; set; }

    public short? ItemTop { get; set; }

    public short? Width { get; set; }

    public short? Height { get; set; }

    public short? Lmargin { get; set; }

    public short? Rmargin { get; set; }

    public short? Tmargin { get; set; }

    public short? Bmargin { get; set; }

    public short? LeftLine { get; set; }

    public short? RightLine { get; set; }

    public short? TopLine { get; set; }

    public short? BottomLine { get; set; }

    public short? Shadow { get; set; }

    public int? Bgred { get; set; }

    public int? Bggreen { get; set; }

    public int? Bgblue { get; set; }

    public int? Fgred { get; set; }

    public int? Fggreen { get; set; }

    public int? Fgblue { get; set; }

    public int? MrkrRed { get; set; }

    public int? MrkrGreen { get; set; }

    public int? MrkrBlue { get; set; }

    public int? BrdrRed { get; set; }

    public int? BrdrGreen { get; set; }

    public int? BrdrBlue { get; set; }

    public short? FromPane { get; set; }

    public short? ToPane { get; set; }

    public short? ItemGroup { get; set; }

    public string? FontName { get; set; }

    public short? FontSize { get; set; }

    public int? TextStyle { get; set; }

    public short? Justific { get; set; }

    public short? Wrap { get; set; }

    public short? PictSize { get; set; }

    public short? DataSource { get; set; }

    public string? ItemStr { get; set; }

    public short? VarNum { get; set; }

    public string? FileName { get; set; }

    public string? FieldNum { get; set; }

    public string? ShowDescr { get; set; }

    public string? CalcType { get; set; }

    public int? ChangFlags { get; set; }

    public short? ApplId { get; set; }

    public short? CalcCol { get; set; }

    public short? Yjustific { get; set; }

    public short? SortLevel { get; set; }

    public string? RevOrder { get; set; }

    public short? SortType { get; set; }

    public string? IsUnique { get; set; }

    public string? IsGroup { get; set; }

    public string? NewPage { get; set; }

    public string? BarCode { get; set; }

    public string? Condition { get; set; }

    public string? LinkTo { get; set; }

    public short? Operator1 { get; set; }

    public short? Operator2 { get; set; }

    public short? Operation { get; set; }

    public short? Bcstandard { get; set; }

    public string? SumInWords { get; set; }

    public string? ExcFonting { get; set; }

    public int? StrIndex { get; set; }

    public short? ContIndex { get; set; }

    public short? ItemIndex { get; set; }

    public short? StrLength { get; set; }

    public string? StrFiller { get; set; }

    public string? RelatedTo { get; set; }

    public string? NextSeg { get; set; }

    public string? HightAdjst { get; set; }

    public string? DupRpttAre { get; set; }

    public int? LnsRpttAre { get; set; }

    public int? RptDupDist { get; set; }

    public string? FieldId { get; set; }

    public string? Fgenabled { get; set; }

    public string? Bgenabled { get; set; }

    public string? Mkenabled { get; set; }

    public string? Bdenabled { get; set; }

    public string? HidEmpRptt { get; set; }

    public string? RpttFtrAll { get; set; }

    public short? GbiDataTyp { get; set; }

    public string? GbiDataLen { get; set; }

    public short? PageBreak { get; set; }

    public string? IsLogo { get; set; }
}
