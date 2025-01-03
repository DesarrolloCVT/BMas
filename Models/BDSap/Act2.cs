using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Act2
{
    public int ContractId { get; set; }

    public int RcpEntry { get; set; }

    public int LogInstanc { get; set; }

    public string? EncryptIv { get; set; }
}
