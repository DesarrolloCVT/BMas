using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rParametrizacion
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public int DocEntry { get; set; }

    public string? Canceled { get; set; }

    public string? Object { get; set; }

    public int? LogInst { get; set; }

    public int? UserSign { get; set; }

    public string? Transfered { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UpdateTime { get; set; }

    public string? DataSource { get; set; }

    public short? UX4rDecimporte { get; set; }

    public short? UX4rDecprecio { get; set; }

    public short? UX4rDectasas { get; set; }

    public short? UX4rDeccantidades { get; set; }

    public short? UX4rDecporcentaje { get; set; }

    public short? UX4rDecunidades { get; set; }

    public string UX4rClidefofventa { get; set; } = null!;

    public string UX4rClideforventa { get; set; } = null!;

    public string UX4rClideffactura { get; set; } = null!;

    public string UX4rClidefboleta { get; set; } = null!;

    public string UX4rClidefncredit { get; set; } = null!;

    public string? UX4rImpuestodef { get; set; }
}
