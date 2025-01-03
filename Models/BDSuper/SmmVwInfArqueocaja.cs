using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwInfArqueocaja
{
    public DateOnly? FechArqCaja { get; set; }

    public int? TotalFectSistema { get; set; }

    public int? TotalEfecCaja { get; set; }

    public int? DifEfectivo { get; set; }

    public int? TotalTarjSistema { get; set; }

    public int? TotalTarjCaja { get; set; }

    public int? DifTarjeta { get; set; }

    public int? TotalTransfSistema { get; set; }

    public int? TotalTransfCaja { get; set; }

    public int? DifTransferencias { get; set; }

    public int? TotalGeneralSistema { get; set; }

    public int? TotalGeneralCaja { get; set; }

    public int? Diferencia { get; set; }

    public string? Observacion { get; set; }
}
