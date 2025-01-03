using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obot
{
    public int AbsEntry { get; set; }

    public short? UserSign { get; set; }

    public string? StatusFrom { get; set; }

    public string? StatusTo { get; set; }

    public DateTime? TranDate { get; set; }

    public short? TranTime { get; set; }

    public string? Reconciled { get; set; }

    public int? TransId { get; set; }

    public DateTime? PostDate { get; set; }

    public DateTime? TaxDate { get; set; }
}
