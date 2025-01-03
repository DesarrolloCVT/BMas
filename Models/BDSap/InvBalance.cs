using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class InvBalance
{
    public string? Bodega { get; set; }

    public string? Articulo { get; set; }

    public string? Descripcion { get; set; }

    public int? Numero { get; set; }

    public int? TipoTrans { get; set; }

    public string Tipo { get; set; } = null!;

    public string DescTrans { get; set; } = null!;

    public string? Docum { get; set; }

    public DateTime? FechaDoc { get; set; }

    public DateTime? FechaCont { get; set; }

    public decimal? Saldo { get; set; }

    public string? Glosa { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Cost { get; set; }

    public decimal? Precio { get; set; }

    public short? Itmsgrpcod { get; set; }

    public decimal? TransValue { get; set; }

    public decimal? Balance { get; set; }

    public decimal? CalcPrice { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? TransNum { get; set; }

    public string? InvntAct { get; set; }

    public decimal? Syscred { get; set; }

    public decimal? Sysdeb { get; set; }
}
