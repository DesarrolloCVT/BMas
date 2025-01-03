using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rCaja2
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

    public string? UX4rCodtienda { get; set; }

    public string? UX4rCodcaja { get; set; }

    public string? UX4rCodigo { get; set; }

    public string? UX4rDocto { get; set; }

    public string? UX4rDoctonombre { get; set; }

    public string UX4rTiposerie { get; set; } = null!;

    public int? UX4rPrimernum { get; set; }

    public int? UX4rSiguientenum { get; set; }

    public int? UX4rUltimonum { get; set; }

    public string? UX4rPrefijofolio { get; set; }
}
