using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Uxilm
{
    public int MessageId { get; set; }

    public int? MinMsgId { get; set; }

    public int? MaxMsgId { get; set; }

    public int? DocEntry { get; set; }

    public int? DocLineNum { get; set; }

    public int? TransType { get; set; }
}
