using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtGrua
{
    public int GruaId { get; set; }

    public string GruaNumero { get; set; } = null!;

    public string GruaDescripcion { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Proveedor { get; set; } = null!;
}
