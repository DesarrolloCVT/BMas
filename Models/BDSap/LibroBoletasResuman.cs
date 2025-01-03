using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class LibroBoletasResuman
{
    public string? Tipo { get; set; }

    public int? Docum { get; set; }

    public int? Numero { get; set; }

    public int? RangoDesde { get; set; }

    public int? RangoHasta { get; set; }

    public DateTime? Fecha { get; set; }

    public string Rut { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Neto { get; set; }

    public decimal? NoAfecto { get; set; }

    public decimal? Ha { get; set; }

    public decimal? Ila10bn { get; set; }

    public decimal? Ila18be { get; set; }

    public decimal? Ila20ce { get; set; }

    public decimal? Ila20vc { get; set; }

    public decimal? Ila31pl { get; set; }

    public decimal? Iva { get; set; }

    public decimal? IvaExe { get; set; }

    public decimal? W4 { get; set; }

    public decimal? Total { get; set; }

    public string? Bodega { get; set; }

    public string? Folio { get; set; }

    public string? Clasif { get; set; }

    public int? Series { get; set; }
}
