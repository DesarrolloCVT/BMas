using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmTotalArqueoReal
{
    public int IdArqCaja { get; set; }

    public DateTime? FechArqCaja { get; set; }

    public int? TotEfecCaja { get; set; }

    public int? TotEfecSist { get; set; }

    public int? TotTarjCaja { get; set; }

    public int? TotTarjSist { get; set; }

    public int? TotCheqCaja { get; set; }

    public int? TotCheqSist { get; set; }

    public int? TotTransfCaja { get; set; }

    public int? TotTransfSist { get; set; }

    public int? TotGenCaja { get; set; }

    public int? TotGenSist { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaHistArqueo { get; set; }

    public string? Observacion { get; set; }
}
