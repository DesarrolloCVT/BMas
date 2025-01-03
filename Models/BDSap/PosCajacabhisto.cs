using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class PosCajacabhisto
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

    public string? UCodTienda { get; set; }

    public string? UCodCaja { get; set; }

    public string? UNomCajero { get; set; }

    public string? UEstado { get; set; }

    public DateTime? UFechaIni { get; set; }

    public short? UHoraIni { get; set; }

    public DateTime? UFechaCie { get; set; }

    public short? UHoraCie { get; set; }

    public string? UClaveCaja { get; set; }

    public string? UIdtrans { get; set; }
}
