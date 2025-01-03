using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ejd1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? Surname { get; set; }

    public string? CommId { get; set; }

    public DateTime? DateOfBrth { get; set; }

    public string? Active { get; set; }
}
