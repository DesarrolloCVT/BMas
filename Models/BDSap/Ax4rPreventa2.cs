using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ax4rPreventa2
{
    public int DocEntry { get; set; }

    public int LineId { get; set; }

    public int? VisOrder { get; set; }

    public string? Object { get; set; }

    public int LogInst { get; set; }

    public string? UItemCode { get; set; }

    public string? UItemName { get; set; }

    public string? UDistNumber { get; set; }

    public string? UMnfSerial { get; set; }

    public string? ULotNumber { get; set; }

    public DateTime? UInDate { get; set; }

    public DateTime? UMnfDate { get; set; }

    public DateTime? UExpDate { get; set; }

    public decimal? UQuantity { get; set; }
}
