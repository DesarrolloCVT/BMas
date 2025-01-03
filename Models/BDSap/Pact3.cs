using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pact3
{
    public int AbsEntry { get; set; }

    public int? ActItemEnt { get; set; }

    public string? TableName { get; set; }

    public string? FieldName { get; set; }

    public string? IsUdf { get; set; }
}
