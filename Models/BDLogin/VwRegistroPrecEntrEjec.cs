using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwRegistroPrecEntrEjec
{
    public int DocEntryEntrada { get; set; }

    public DateOnly? FechaEjec { get; set; }

    public DateTime FechaEjecucion { get; set; }

    public int Oc { get; set; }

    public decimal ValorOc { get; set; }

    public decimal ValorOchoy { get; set; }

    public decimal ValorDolarOc { get; set; }

    public decimal ValorDolarHoy { get; set; }

    public decimal DifCambio { get; set; }

    public decimal? DifCambioAplicado { get; set; }

    public decimal? PesoOc { get; set; }

    public decimal? PesoEntrada { get; set; }
}
