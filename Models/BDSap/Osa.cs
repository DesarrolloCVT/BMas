using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osa
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public int? AdBoardId { get; set; }

    public int? CadBoardId { get; set; }
}
