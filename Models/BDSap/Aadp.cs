﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aadp
{
    public string PrintId { get; set; } = null!;

    public int? ObjList { get; set; }

    public short? MaxLineNum { get; set; }

    public short? TopMrgn { get; set; }

    public short? BtmMrgn { get; set; }

    public short? LftMrgn { get; set; }

    public short? RgtMrgn { get; set; }

    public string? PrnCompany { get; set; }

    public string? MnhlNote { get; set; }

    public short? MaxWordLin { get; set; }

    public short? VCompress { get; set; }

    public string? WordPath { get; set; }

    public string? BitmapPath { get; set; }

    public string? PrintMeta { get; set; }

    public string? PrintRcpt { get; set; }

    public string? ShortRcpt { get; set; }

    public string? ExportCode { get; set; }

    public string? AttachPath { get; set; }

    public string? DraftNote { get; set; }

    public string? ExtPath { get; set; }

    public string? DmePath { get; set; }

    public short? Sntype { get; set; }

    public string? Gbipath { get; set; }

    public string? LogoFile { get; set; }

    public byte[]? LogoImage { get; set; }

    public string? B1server { get; set; }

    public string? IsTrustSrv { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign2 { get; set; }

    public int? SnapShotId { get; set; }

    public string? DefirExpP { get; set; }

    public string? DefirDemop { get; set; }

    public string? PrintPdf { get; set; }

    public string? PrtCancel { get; set; }

    public string? PrtUseSys { get; set; }

    public string? RptList { get; set; }

    public string? PreAttach { get; set; }

    public string? ExportPdf { get; set; }

    public string? AttachPdf { get; set; }

    public string? Gstpath { get; set; }
}
