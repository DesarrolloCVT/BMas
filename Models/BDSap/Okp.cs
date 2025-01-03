using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Okp
{
    public string KpsCode { get; set; } = null!;

    public string? KpsName { get; set; }

    public string? KpsType { get; set; }

    public int? FieldsNum { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign { get; set; }
}
