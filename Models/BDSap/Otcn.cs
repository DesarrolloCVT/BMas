using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otcn
{
    public int AbsEntry { get; set; }

    public string Ccdnum { get; set; } = null!;

    public DateTime? Date { get; set; }

    public string? CustTerm { get; set; }

    public string? CntrOrigin { get; set; }

    public string DirectImp { get; set; } = null!;

    public string? CardCode { get; set; }
}
