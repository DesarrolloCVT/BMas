using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Imltm
{
    public int Id { get; set; }

    public string? UsrCode { get; set; }

    public string? Peer { get; set; }

    public int? GrpId { get; set; }

    public DateTime? DptTime { get; set; }
}
