using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pwz1
{
    public int IdEntry { get; set; }

    public string CardCode { get; set; } = null!;

    public string? CardName { get; set; }

    public string? CardType { get; set; }

    public string? Checked { get; set; }

    public string? Bpcurrency { get; set; }

    public string? BpsingleP { get; set; }

    public string? Dppstatus { get; set; }
}
