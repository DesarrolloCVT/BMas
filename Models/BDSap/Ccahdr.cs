using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ccahdr
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? USocios { get; set; }

    public string? UVendors { get; set; }

    public string? UCustomers { get; set; }
}
