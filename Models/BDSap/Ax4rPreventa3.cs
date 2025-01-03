using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ax4rPreventa3
{
    public int DocEntry { get; set; }

    public int LineId { get; set; }

    public int? VisOrder { get; set; }

    public string? Object { get; set; }

    public int LogInst { get; set; }

    public decimal? UQuantity { get; set; }

    public DateTime? UShipDate { get; set; }

    public string? UWhsCode { get; set; }

    public string? UShipToCode { get; set; }

    public short? UHora { get; set; }
}
