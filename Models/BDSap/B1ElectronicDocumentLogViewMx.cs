﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1ElectronicDocumentLogViewMx
{
    public int AbsEntry { get; set; }

    public string Code { get; set; } = null!;

    public string? ActType { get; set; }

    public string? ActStatus { get; set; }

    public string? ActDesc { get; set; }

    public string? ActMessage { get; set; }

    public int? ActEnv { get; set; }

    public string? SrcObjType { get; set; }

    public int? SrcObjAbs { get; set; }

    public short? Submits { get; set; }

    public DateTime? SendDate { get; set; }

    public int? SendTime { get; set; }

    public DateTime? LogOpDate { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? IsRemoved { get; set; }

    public string? Cancelation { get; set; }

    public string? SendData { get; set; }

    public string? RecvData { get; set; }

    public string? Uuid { get; set; }

    public int? DocNum { get; set; }

    public int? Series { get; set; }

    public string? DocCanceled { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public DateTime? DocCreateDate { get; set; }

    public int? DocCreateTime { get; set; }

    public string? ReceptorRfc { get; set; }

    public string? TestMode { get; set; }

    public string? EmisorRfc { get; set; }

    public string? GenType { get; set; }

    public int? Bplid { get; set; }
}