using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oscg
{
    public int AbsEntry { get; set; }

    public string ServiceCtg { get; set; } = null!;

    public string? Descrip { get; set; }
}
