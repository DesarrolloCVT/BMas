using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtActivoFijo
{
    public int IdActivo { get; set; }

    public string? Placa { get; set; }

    public string NombreActivo { get; set; } = null!;

    public DateOnly FechaCompra { get; set; }

    public int? NFactura { get; set; }

    public string CuentaContable { get; set; } = null!;

    public int VidaUtilMeses { get; set; }

    public int? VidaUtilRestante { get; set; }

    public int? VidaUtilTranscurrida { get; set; }

    public decimal? ValorCompraNeto { get; set; }

    public decimal? Cmac { get; set; }

    public decimal? Cmej { get; set; }

    public decimal? Depac { get; set; }

    public decimal? Depej { get; set; }

    public decimal? Cmda { get; set; }

    public short? Beneficio33bis { get; set; }

    public decimal? MontoBeneficio33bis { get; set; }

    public decimal? ValorFinalActivo { get; set; }

    public string? Dvision { get; set; }

    public string? UnidAdministrativa { get; set; }

    public string? CentroCosto { get; set; }

    public string? LugarFisico { get; set; }

    public DateOnly? FechaInicioDepresiacion { get; set; }
}
