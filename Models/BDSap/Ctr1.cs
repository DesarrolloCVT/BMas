using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ctr1
{
    public int ContractId { get; set; }

    public int Line { get; set; }

    public string? ManufSn { get; set; }

    public string? InternalSn { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public short? ItemGroup { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? ItmGrpName { get; set; }

    public int? InsId { get; set; }

    public DateTime? TermDate { get; set; }

    public int? LogInstanc { get; set; }

    public string? EncryptIv { get; set; }
}
