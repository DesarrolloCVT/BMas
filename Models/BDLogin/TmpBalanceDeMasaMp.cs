using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class TmpBalanceDeMasaMp
{
    public int? NumOf { get; set; }

    public decimal? CantidadDeOf { get; set; }

    public string? LoteCons { get; set; }

    public decimal? RepConsumido { get; set; }

    public decimal? ConsOtrosLotes { get; set; }

    public decimal? TotalConsumido { get; set; }

    public decimal? ProducidoReal { get; set; }

    public decimal? Reproceso { get; set; }

    public decimal? Barrido { get; set; }

    public decimal? TotalProducido { get; set; }

    public decimal? DifConsumo { get; set; }

    public decimal? SobreDosificado { get; set; }

    public decimal? PorcProdTotal { get; set; }

    public decimal? CantLoteTrazado { get; set; }

    public DateTime? FechaOf { get; set; }
}
