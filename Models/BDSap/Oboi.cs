using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oboi
{
    public int AbsEntry { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public int? QueryId { get; set; }

    public int? Qcategory { get; set; }

    public string? Desc { get; set; }

    public int? MenuId { get; set; }
}
