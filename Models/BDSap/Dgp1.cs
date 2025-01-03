using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dgp1
{
    public int AbsEntry { get; set; }

    public string CardCode { get; set; } = null!;

    public string? CardName { get; set; }

    public string? Checked { get; set; }

    public string? CtrlAcct { get; set; }
}
