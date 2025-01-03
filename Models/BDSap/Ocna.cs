using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocna
{
    public int AbsId { get; set; }

    public string Cnaecode { get; set; } = null!;

    public string? Descrip { get; set; }
}
