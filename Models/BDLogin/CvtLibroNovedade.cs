using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLibroNovedade
{
    public int NovedadId { get; set; }

    public DateTime Fecha { get; set; }

    public string Actividad { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int UsuarioId { get; set; }
}
