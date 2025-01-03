using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class CvtPallprodcli
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UCardCode { get; set; }

    public string? UItemCode { get; set; }

    public short? UCantBase { get; set; }

    public short? UUnidXpallet { get; set; }

    public short? UCantAltura { get; set; }

    public short? UCodIdcontenedor { get; set; }

    public string? UShipToCode { get; set; }
}
