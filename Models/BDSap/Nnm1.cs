using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Nnm1
{
    public string ObjectCode { get; set; } = null!;

    public int Series { get; set; }

    public string SeriesName { get; set; } = null!;

    public int? InitialNum { get; set; }

    public int? NextNumber { get; set; }

    public int? LastNum { get; set; }

    public string? BeginStr { get; set; }

    public string? EndStr { get; set; }

    public string? Remark { get; set; }

    public short? GroupCode { get; set; }

    public string? Locked { get; set; }

    public string? YearTransf { get; set; }

    public string? Indicator { get; set; }

    public string? Template { get; set; }

    public int? NumSize { get; set; }

    public string? FolioPref { get; set; }

    public int? NextFolio { get; set; }

    public string DocSubType { get; set; } = null!;

    public short? DefEseries { get; set; }

    public string? IsDigSerie { get; set; }

    public string SeriesType { get; set; } = null!;

    public string? IsManual { get; set; }

    public int? Bplid { get; set; }

    public string? IsForCncl { get; set; }

    public string? AtDocType { get; set; }

    public string? IsElAuth { get; set; }

    public string? CoAccount { get; set; }

    public string? GenPassprt { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? LogInstanc { get; set; }

    public int? PinvType { get; set; }

    public int? NinvType { get; set; }

    public string? AssignedId { get; set; }

    public string? Action { get; set; }

    public string? Status { get; set; }

    public string? Phase { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
