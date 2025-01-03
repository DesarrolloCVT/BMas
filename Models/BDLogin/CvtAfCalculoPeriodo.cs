using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAfCalculoPeriodo
{
    public int Año { get; set; }

    public int Mes { get; set; }

    public DateOnly? Periodo { get; set; }

    public int IdActivo { get; set; }

    public string? Placa { get; set; }

    public string NombreActivo { get; set; } = null!;

    public DateOnly FechaCompra { get; set; }

    public decimal? NFactura { get; set; }

    public string CuentaContable { get; set; } = null!;

    public int VidaUtilMeses { get; set; }

    public int? VidaUtilRestante { get; set; }

    public int? VidaUtilTranscurrida { get; set; }

    public decimal? ValorCompraNeto { get; set; }

    public decimal? Cmac { get; set; }

    public decimal? Cmej { get; set; }

    public decimal? Depac { get; set; }

    public decimal? Depej { get; set; }

    public short? Beneficio33bis { get; set; }

    public decimal? MontoBeneficio33bis { get; set; }

    public decimal? ValorFinalActivoAnt { get; set; }

    public decimal? ValorParaCm { get; set; }

    public decimal? CmEje { get; set; }

    public decimal? CmEjeAprox { get; set; }

    public decimal? Cmda { get; set; }

    public decimal? CmdaAprox { get; set; }

    public decimal? MontoADepreciar { get; set; }

    public decimal? MontoADepreciarAprox { get; set; }

    public decimal? Factor { get; set; }

    public decimal? DepresiacionEje { get; set; }

    public decimal? DepresiacionEjeAprox { get; set; }

    public decimal? ValorFinalActivoNuevo { get; set; }

    public string? Dvision { get; set; }

    public string? UnidAdministrativa { get; set; }

    public string? CentroCosto { get; set; }

    public string? LugarFisico { get; set; }
}
