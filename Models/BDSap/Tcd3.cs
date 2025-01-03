using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tcd3
{
    public int AbsId { get; set; }

    public int Tcd2Id { get; set; }

    public DateTime EfctFrom { get; set; }

    public DateTime? EfctTo { get; set; }

    public string? TaxCode { get; set; }
}
