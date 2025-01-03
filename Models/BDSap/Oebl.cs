using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oebl
{
    public int AbsEntry { get; set; }

    public string? WizardName { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign { get; set; }
}
