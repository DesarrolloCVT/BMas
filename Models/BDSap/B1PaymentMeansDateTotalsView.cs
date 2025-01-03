using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1PaymentMeansDateTotalsView
{
    public string? PayObjType { get; set; }

    public int PayAbsEntry { get; set; }

    public int? MeansType { get; set; }

    public int? MeansLine { get; set; }

    public int? MeansAbsEntry { get; set; }

    public int? MeansId { get; set; }

    public string? MeansStrId { get; set; }

    public DateTime? MeansDate { get; set; }

    public decimal? MeansDateTotal { get; set; }

    public decimal? DocTotalSum { get; set; }

    public decimal? MeansPart { get; set; }
}
