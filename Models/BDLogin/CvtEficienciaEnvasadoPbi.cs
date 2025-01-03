using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtEficienciaEnvasadoPbi
{
    public int Of { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Dia { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public short? Sala { get; set; }

    public string? Linea { get; set; }

    public string? Operador { get; set; }

    public string? Abocador { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public TimeOnly? HoraInicio { get; set; }

    public TimeOnly? HoraTermino { get; set; }

    public int? MinTurno { get; set; }

    public int? DetPlanificada { get; set; }

    public int? DetNoPlanificada { get; set; }

    public int? DetSinCategorizar { get; set; }

    public int? DetTotal { get; set; }

    public int? MinDisponibles { get; set; }

    public int? MinReales { get; set; }

    public int? GolpesEsperados { get; set; }

    public string? GolpesReales { get; set; }

    public decimal? ProduccionEsperada { get; set; }

    public int? ProduccionReal { get; set; }

    public decimal? Pnc { get; set; }

    public decimal? Disponibilidad { get; set; }

    public decimal? Rendimiento { get; set; }

    public decimal? Calidad { get; set; }

    public decimal? Oee { get; set; }
}
