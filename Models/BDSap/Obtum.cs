using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obtum
{
    public int AbsEntry { get; set; }

    public string? Status { get; set; }

    public string? Canceled { get; set; }

    public int DocNum { get; set; }

    public decimal? DocRate { get; set; }

    public int? TaxCat { get; set; }

    public short? Type { get; set; }

    public short? Oper { get; set; }

    public int? RefVisType { get; set; }

    public int? RefObjType { get; set; }

    public int? RefDocEnt { get; set; }

    public int? RefDocNum { get; set; }

    public string? StateUf { get; set; }

    public DateTime? PostDate { get; set; }

    public string? CodDa { get; set; }

    public string? NumDa { get; set; }

    public string? CodAut { get; set; }

    public decimal? VlDa { get; set; }

    public decimal? VlDaSc { get; set; }

    public DateTime? DtVcto { get; set; }

    public DateTime? DtPgto { get; set; }

    public string? CodAj { get; set; }

    public string? DescCompAj { get; set; }

    public decimal? BcIcms { get; set; }

    public decimal? BcIcmsSc { get; set; }

    public decimal? AliqIcms { get; set; }

    public decimal? VlIcms { get; set; }

    public decimal? VlIcmsSc { get; set; }

    public decimal? VlOutros { get; set; }

    public string? CodAjApur { get; set; }

    public string? NumProc { get; set; }

    public string? IndProc { get; set; }

    public string? Ser { get; set; }

    public string? Sub { get; set; }

    public int? NumDoc { get; set; }

    public DateTime? DtDoc { get; set; }

    public string? CodMod { get; set; }

    public string? CodPart { get; set; }

    public string? CodRec { get; set; }

    public string? Glacct { get; set; }

    public string? ItemCode { get; set; }

    public int? Bplid { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? TransId { get; set; }
}
