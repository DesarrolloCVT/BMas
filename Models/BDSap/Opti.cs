using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opti
{
    public string Code { get; set; } = null!;

    public string? Desc { get; set; }

    public string? Type { get; set; }

    public DateTime? SopDate { get; set; }

    public DateTime? EndOpDate { get; set; }

    public string? Remarks { get; set; }

    public int? EdocExpFrm { get; set; }

    public int? Bplid { get; set; }

    public string? EdocGenTyp { get; set; }
}
