using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aec6
{
    public int Code { get; set; }

    public string? GenType { get; set; }

    public int? MapId { get; set; }

    public int? MapIdWs { get; set; }

    public string? TestMode { get; set; }

    public short LogInstanc { get; set; }

    public string? ParamLogic { get; set; }

    public string? ParamStr { get; set; }

    public string? ParamLtext { get; set; }

    public string? ActStatus { get; set; }

    public int? ParamUqc { get; set; }

    public int? ParamInt { get; set; }
}
