using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwResumenProduccion
{
    public int Of { get; set; }

    public short? Sala { get; set; }

    public string? Linea { get; set; }

    public string Maquina { get; set; } = null!;

    public string CategoriaNombre { get; set; } = null!;

    public string DetencionMotivo { get; set; } = null!;

    public int? TotalMinutosDetencion { get; set; }

    public string? Comentario { get; set; }

    public int? CantPtreal { get; set; }

    public int? Reproceso { get; set; }

    public int? Barrido { get; set; }

    public string? Operador { get; set; }

    public string? Turno { get; set; }

    public DateTime? Fecha { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public string Familia { get; set; } = null!;

    public int? Dia { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public int Expr1 { get; set; }

    public decimal? PorcCumplimiento { get; set; }

    public int? Meta { get; set; }

    public int? TotalDetenciones { get; set; }
}
