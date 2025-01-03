﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aitt
{
    public string Code { get; set; } = null!;

    public string? TreeType { get; set; }

    public short? PriceList { get; set; }

    public decimal? Qauntity { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Transfered { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public short? Scncounter { get; set; }

    public string? DispCurr { get; set; }

    public string? ToWh { get; set; }

    public string? Object { get; set; }

    public int LogInstac { get; set; }

    public int? UserSign2 { get; set; }

    public string? OcrCode { get; set; }

    public string? HideComp { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public int? UpdateTime { get; set; }

    public string? Project { get; set; }

    public decimal? PlAvgSize { get; set; }

    public string? Name { get; set; }

    public int? CreateTs { get; set; }

    public int? UpdateTs { get; set; }

    public int? AtcEntry { get; set; }

    public string? Attachment { get; set; }
}
