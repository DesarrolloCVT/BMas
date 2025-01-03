using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroHallazgoMateriaExtraña
{
    public int IdRegistroHallazgo { get; set; }

    public DateOnly FechaHallazgo { get; set; }

    public string Turno { get; set; } = null!;

    public int SalaId { get; set; }

    public int IdArea { get; set; }

    public string ItemCode { get; set; } = null!;

    public int IdTipoHallazgo { get; set; }

    public string? DescripcionMe { get; set; }

    public int? CantHallazgos { get; set; }

    public string CardCode { get; set; } = null!;

    public int OfProducto { get; set; }

    public bool ProveedorMixto { get; set; }

    public int? IdPersonal { get; set; }
}
