using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmExhibicionSala
{
    public int IdExhibicion { get; set; }

    public string? Pasillo { get; set; }

    public int? Columna { get; set; }

    public int? Nivel { get; set; }

    public string? CodBarra { get; set; }

    public string? CodProducto { get; set; }

    public int? CantCaras { get; set; }
}
