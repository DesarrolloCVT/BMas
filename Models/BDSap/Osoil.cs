using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osoil
{
    public string Soiwnum { get; set; } = null!;

    public int? WizardId { get; set; }

    public int? Soinum { get; set; }

    public int AbsEntry { get; set; }
}
