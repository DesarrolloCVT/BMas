using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtMotivoDevolucion
{
    public int IdMotivoDevolucion { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? Estado { get; set; }
}
