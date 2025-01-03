using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pci1
{
    public int InstancePk { get; set; }

    public int LineNum { get; set; }

    public string? BpmnelId { get; set; }

    public string? BpmnelDes { get; set; }

    public string? ParamType { get; set; }

    public string? ParamKey { get; set; }

    public string? ParamVal { get; set; }
}
