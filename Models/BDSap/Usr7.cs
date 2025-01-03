using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Usr7
{
    public short UserId { get; set; }

    public short GroupId { get; set; }

    public string? Category { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }
}
