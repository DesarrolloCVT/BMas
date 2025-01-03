using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Shr1
{
    public int ShrId { get; set; }

    public int RowId { get; set; }

    public short? CatId { get; set; }

    public string? LineNum { get; set; }

    public string? ItemName { get; set; }

    public short? Level { get; set; }

    public string? IndentChar { get; set; }

    public string? Formula { get; set; }

    public decimal? CurAmount { get; set; }

    public decimal? PreAmount { get; set; }
}
