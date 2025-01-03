using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obob
{
    public int ObjectId { get; set; }

    public string? TableName { get; set; }

    public string? PrimaryKey { get; set; }

    public string? TitleField { get; set; }

    public string? DescField { get; set; }

    public string? DeviceType { get; set; }

    public string? UsedBy { get; set; }
}
