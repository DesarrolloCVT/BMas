using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Het1
{
    public int TransferId { get; set; }

    public int EmpId { get; set; }

    public DateTime? Transfered { get; set; }

    public string? Status { get; set; }

    public string? Comment { get; set; }

    public short? TransTime { get; set; }
}
