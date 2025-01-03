using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cpl1
{
    public int AbsEntry { get; set; }

    public int LogId { get; set; }

    public string? ObjectId { get; set; }

    public string? Instance { get; set; }

    public string? ErrCode { get; set; }

    public string? MessageId { get; set; }

    public string? MessageDes { get; set; }

    public string? InstName { get; set; }
}
