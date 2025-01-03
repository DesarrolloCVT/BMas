using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ojst
{
    public int AbsId { get; set; }

    public DateTime? DocDate { get; set; }

    public string? Comments { get; set; }

    public string? JrnlMemo { get; set; }

    public int? TransId { get; set; }

    public int? LogInstanc { get; set; }

    public int? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTime { get; set; }

    public int? DepositNum { get; set; }

    public string? CertNum { get; set; }
}
