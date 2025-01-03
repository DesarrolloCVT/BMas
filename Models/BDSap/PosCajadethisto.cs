using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class PosCajadethisto
{
    public string Code { get; set; } = null!;

    public int LineId { get; set; }

    public string? Object { get; set; }

    public int? LogInst { get; set; }

    public string? UCodTienda { get; set; }

    public string? UCodCaja { get; set; }

    public string? UCodMoneda { get; set; }

    public decimal? USaldoInicial { get; set; }

    public decimal? USaldoFinal { get; set; }

    public decimal? UX4rSaldoCheque { get; set; }

    public decimal? UX4rSaldoTransf { get; set; }

    public decimal? UX4rSaldoTarj { get; set; }

    public decimal? UX4rSaldoPers { get; set; }

    public decimal? UX4rSaldoEfect { get; set; }
}
