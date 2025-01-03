using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odph
{
    public int AbsEntry { get; set; }

    public string? UserSign { get; set; }

    public string? TmpltName { get; set; }

    public string? TmpltCnt { get; set; }

    public DateTime? CrtDate { get; set; }
}
