using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oigw
{
    public int AbsEntry { get; set; }

    public short ItmsGrpCod { get; set; }

    public string WhsCode { get; set; } = null!;

    public int? DftBinAbs { get; set; }

    public string? DftBinEnfd { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
