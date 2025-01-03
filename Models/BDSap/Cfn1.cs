using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cfn1
{
    public int AbsEntry { get; set; }

    public int ItemIndex { get; set; }

    public string? UserMenu { get; set; }

    public string? MenuUid { get; set; }

    public string? Name { get; set; }
}
