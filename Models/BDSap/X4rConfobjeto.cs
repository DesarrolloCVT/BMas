using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rConfobjeto
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

    public string? UX4rObjeto { get; set; }

    public string? UX4rCampo { get; set; }

    public string? UX4rDescripcion { get; set; }

    public string? UX4rPropiedad { get; set; }

    public string? UX4rTipo { get; set; }

    public int? UX4rLargo { get; set; }

    public int? UX4rDecimales { get; set; }

    public short? UX4rOrden { get; set; }

    public string? UX4rObligatorio { get; set; }

    public string? UX4rTabla { get; set; }

    public short? UX4rPestana { get; set; }

    public string? UX4rActivo { get; set; }

    public string? UX4rSql { get; set; }

    public string? UX4rDetalle { get; set; }

    public string? UX4rHabilitado { get; set; }

    public string? UX4rDefecto { get; set; }

    public string? UX4rNamesp { get; set; }
}
