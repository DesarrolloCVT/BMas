using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class Layout
{
    public int LayoutId { get; set; }

    public int SiteId { get; set; }

    public string? LayoutDescription { get; set; }

    public int? LayoutYPasillo { get; set; }

    public int? LayoutXFila { get; set; }

    public string UbicacionxDefecto { get; set; } = null!;

    public int? CantidadUbicaciones { get; set; }

    public int? LayoutZColumna { get; set; }

    public string? Descripcion { get; set; }
}
