using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class TransferDetail
{
    public int SiteId { get; set; }

    public int TransferId { get; set; }

    public int PackageId { get; set; }

    public int? LayoutIdActual { get; set; }

    public int? Status { get; set; }

    public DateTime? Date { get; set; }

    public decimal? PackageQuantity { get; set; }

    public short? PackageConfirm { get; set; }
}
