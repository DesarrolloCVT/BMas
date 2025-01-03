using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Imglg
{
    public int Id { get; set; }

    public string? From { get; set; }

    public int? GrpId { get; set; }

    public string? Msg { get; set; }

    public DateTime? Time { get; set; }

    public string? Nty { get; set; }
}
