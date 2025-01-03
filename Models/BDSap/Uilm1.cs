using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Uilm1
{
    public int MessageId { get; set; }

    public string ItemCode { get; set; } = null!;

    public int SysNumber { get; set; }

    public decimal? Quantity { get; set; }

    public int? MdAbsEntry { get; set; }
}
