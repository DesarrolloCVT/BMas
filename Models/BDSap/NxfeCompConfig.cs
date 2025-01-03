using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class NxfeCompConfig
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public string UTstMode { get; set; } = null!;

    public string? UUrlDteService { get; set; }

    public string? UUrlDocService { get; set; }

    public string? UUrlFaceleUsr { get; set; }

    public string? UUrlFacelePwd { get; set; }

    public string? UItemCode { get; set; }

    public string? UUnitCode { get; set; }

    public string UDrftModeSrv { get; set; } = null!;

    public string UDrftModeItm { get; set; } = null!;

    public string UDrftModeEmpty { get; set; } = null!;

    public string UTpoDocRefFa { get; set; } = null!;

    public string UTpoDocRefPy { get; set; } = null!;

    public string UTpoDocRefSn { get; set; } = null!;

    public string UCantReg { get; set; } = null!;

    public string UPryMonitor { get; set; } = null!;

    public string? UIndicador { get; set; }
}
