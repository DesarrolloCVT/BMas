using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opo
{
    public string EquipNo { get; set; } = null!;

    public string? Model { get; set; }

    public string? ManufSn { get; set; }

    public short? RegNo { get; set; }

    public string? Nfmodel { get; set; }
}
