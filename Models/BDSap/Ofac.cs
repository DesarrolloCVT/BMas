using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofac
{
    public int AbsEntry { get; set; }

    public string? ItemCode { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
