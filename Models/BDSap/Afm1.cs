using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Afm1
{
    public int FmlId { get; set; }

    public int DispOrder { get; set; }

    public string? VarName { get; set; }

    public string? Category { get; set; }

    public string? Parameter { get; set; }

    public string? DataType { get; set; }

    public int LogInstanc { get; set; }
}
