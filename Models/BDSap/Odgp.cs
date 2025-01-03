using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odgp
{
    public int AbsEntry { get; set; }

    public string SetName { get; set; } = null!;

    public string? SetDesc { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public short? UserSign { get; set; }

    public string? Target { get; set; }

    public DateTime? PostDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public int? Series { get; set; }

    public string? Items { get; set; }

    public string? ItemSmmry { get; set; }

    public string? Service { get; set; }

    public string? ServSmmry { get; set; }

    public string? ExchgRate { get; set; }

    public string? CreatDraft { get; set; }

    public string? BaseQut { get; set; }

    public string? BaseRdr { get; set; }

    public string? BaseDln { get; set; }

    public string? BaseRdn { get; set; }

    public string? BaseResInv { get; set; }

    public string? ExpndSel { get; set; }

    public string? SortField { get; set; }

    public string? Consolidat { get; set; }

    public string? ExpandCons { get; set; }

    public string? Rcnsummary { get; set; }

    public int? ChainCode { get; set; }

    public int? OredrNum1 { get; set; }

    public int? OredrNum2 { get; set; }

    public string? Direct { get; set; }

    public string? Indirect { get; set; }

    public string? DoReport { get; set; }

    public string? FileExport { get; set; }

    public string? SavePath { get; set; }

    public string? DealNum { get; set; }

    public string? UseDirect { get; set; }

    public string? NoItmCode { get; set; }

    public string? OnData { get; set; }

    public string? OnLedger { get; set; }

    public string? OnInvnt { get; set; }

    public string? Summary { get; set; }

    public string? AltItmDocs { get; set; }

    public string? PartDelivr { get; set; }

    public string? ConsiderBp { get; set; }

    public string? ConsiderTy { get; set; }

    public string? EdocGenTyp { get; set; }

    public short? Eseries { get; set; }

    public string? EdocNum { get; set; }

    public string? ReopOriRdr { get; set; }

    public string? ReopManCls { get; set; }

    public short? SeqCode { get; set; }

    public string? UseBaseSeq { get; set; }

    public string? OnSeqCode { get; set; }

    public int? Bplid { get; set; }

    public string? BlckFrOnly { get; set; }

    public string? DocSubType { get; set; }

    public string? EdocDflt { get; set; }

    public int? EdocMapId { get; set; }

    public DateTime? VatDate { get; set; }

    public string? BsPrcMode { get; set; }
}
