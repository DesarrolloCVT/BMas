using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rCusuarioChfl
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

    public short? UX4rFieldId { get; set; }

    public string? UX4rCampo { get; set; }

    public string? UX4rDescripcion { get; set; }
}
