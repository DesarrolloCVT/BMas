using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cumf
{
    public int FolderId { get; set; }

    public string? FolderName { get; set; }

    public int? SortNum { get; set; }

    public short UserSign { get; set; }

    public int? FatherId { get; set; }
}
