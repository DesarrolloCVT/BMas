using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acr12
{
    public string CardCode { get; set; } = null!;

    public int ProtCode { get; set; }

    public string? GenType { get; set; }

    public int? MapId { get; set; }

    public int LogInstanc { get; set; }

    public string? VatStruct { get; set; }

    public string? ParticipId { get; set; }

    public string? ElecUid { get; set; }
}
