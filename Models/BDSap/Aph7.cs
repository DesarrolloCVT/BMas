using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aph7
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public int? StageId { get; set; }

    public int? Docnum { get; set; }

    public int? DocEntry { get; set; }

    public int LogInstanc { get; set; }

    public string? Chargeable { get; set; }

    public decimal? Charged { get; set; }

    public string? EncryptIv { get; set; }
}
