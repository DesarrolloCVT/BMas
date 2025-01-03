using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1OcrbIbanview
{
    public int AbsEntry { get; set; }

    public string CardCode { get; set; } = null!;

    public string? Iban { get; set; }
}
