using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPresupuestoInformeVendedorAño
{
    public int PresupuestoId { get; set; }

    public int Año { get; set; }

    public int Vendedor { get; set; }

    public string? TipoPresupuesto { get; set; }

    public string CardCode { get; set; } = null!;

    public string CardName { get; set; } = null!;

    public string Itemcode { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public int? Enero { get; set; }

    public decimal? EneroPa { get; set; }

    public int? Febrero { get; set; }

    public decimal? FebreroPa { get; set; }

    public int? Marzo { get; set; }

    public decimal? MarzoPa { get; set; }

    public int? Abril { get; set; }

    public decimal? AbrilPa { get; set; }

    public int? Mayo { get; set; }

    public decimal? MayoPa { get; set; }

    public int? Junio { get; set; }

    public decimal? JunioPa { get; set; }

    public int? Julio { get; set; }

    public decimal? JulioPa { get; set; }

    public int? Agosto { get; set; }

    public decimal? AgostoPa { get; set; }

    public int? Septiembre { get; set; }

    public decimal? SeptiembrePa { get; set; }

    public int? Octubre { get; set; }

    public decimal? OctubrePa { get; set; }

    public int? Noviembre { get; set; }

    public decimal? NoviembrePa { get; set; }

    public int? Diciembre { get; set; }

    public decimal? DiciembrePa { get; set; }
}
