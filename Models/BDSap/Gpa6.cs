using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gpa6
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public int? PodocAbs { get; set; }

    public decimal? Applied { get; set; }
}
