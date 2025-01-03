using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oimt
{
    public string ValuatType { get; set; } = null!;

    public int TransType { get; set; }

    public short BaseType { get; set; }

    public short TemplateId { get; set; }

    public string LocalizId { get; set; } = null!;

    public short Action { get; set; }

    public string? Jeposting { get; set; }

    public short? LineActTyp { get; set; }

    public short TmpType { get; set; }

    public string? Total { get; set; }
}
