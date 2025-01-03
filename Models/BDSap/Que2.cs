using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Que2
{
    public string QueueId { get; set; } = null!;

    public string ObjType { get; set; } = null!;

    public int ElementId { get; set; }

    public int ElementNum { get; set; }

    public int? Priority { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }
}
