using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1DocItemView
{
    public int DocItemType { get; set; }

    public string DocItemCode { get; set; } = null!;

    public string? DocItemName { get; set; }

    public string? DocItemAsInventory { get; set; }
}
