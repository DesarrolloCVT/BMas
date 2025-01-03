using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oppa
{
    public int AbsEntry { get; set; }

    public string? SecLevel { get; set; }

    public int? PwdExp { get; set; }

    public int? PwdMinLen { get; set; }

    public int? MinUppers { get; set; }

    public int? MinLowCase { get; set; }

    public int? MinDigits { get; set; }

    public int? MinNonAlph { get; set; }

    public int? NumPrevPwd { get; set; }

    public int? NumAuthLoc { get; set; }

    public string? PwdExample { get; set; }
}
