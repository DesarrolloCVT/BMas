using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocrt
{
    public int Id { get; set; }

    public string? NodeStr { get; set; }

    public int? FatherId { get; set; }

    public string? TableName { get; set; }
}
