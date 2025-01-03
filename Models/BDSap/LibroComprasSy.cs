using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class LibroComprasSy
{
    public string Tipo { get; set; } = null!;

    public int? Docum { get; set; }

    public string? Numero { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Rut { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Neto { get; set; }

    public decimal? NoAfecto { get; set; }

    public decimal? Ha { get; set; }

    public decimal? Ic { get; set; }

    public decimal? Ila10bn { get; set; }

    public decimal? Ila18be { get; set; }

    public decimal? Ila20ce { get; set; }

    public decimal? Ila20vc { get; set; }

    public decimal? Ila31pl { get; set; }

    public decimal? Iva { get; set; }

    public decimal? IvaExe { get; set; }

    public decimal? W2 { get; set; }

    public decimal? W4 { get; set; }

    public decimal? Total { get; set; }

    public DateTime? Fechacon { get; set; }

    public string? Clasif { get; set; }

    public int DocEntry { get; set; }

    public int? Dummy { get; set; }
}
