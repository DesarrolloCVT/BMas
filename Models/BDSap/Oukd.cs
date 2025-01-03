using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oukd
{
    public string TableName { get; set; } = null!;

    public short KeyId { get; set; }

    public string? KeyName { get; set; }

    public string? UniqueKey { get; set; }

    public string? Action { get; set; }
}
