using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlPesoProductoPalletizadoDetalle
{
    public int IdDetControlPesoPallet { get; set; }

    public int? IdContrPesoPallet { get; set; }

    public TimeOnly? HoraPeso { get; set; }

    public int? Npallet { get; set; }

    public TimeOnly? HoraTermPallet { get; set; }

    public decimal? PesoPallet { get; set; }

    public int? Sscc { get; set; }

    public string? AccionCorrectiva { get; set; }

    public string? Observaciones { get; set; }

    public string? Nlinea { get; set; }

    public decimal? SaldoPallet { get; set; }

    public decimal? Merma { get; set; }
}
