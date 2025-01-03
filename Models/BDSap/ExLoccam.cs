using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class ExLoccam
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

    public string? UCampo { get; set; }

    public string? UCabDet { get; set; }

    public string? UTabla { get; set; }

    public string? UDefecto { get; set; }

    public string? UNombre { get; set; }

    public short? UTamano { get; set; }

    public string? UTablaSap { get; set; }

    public string? UTablaUdo { get; set; }

    public string? UTablaObjeto { get; set; }
}
