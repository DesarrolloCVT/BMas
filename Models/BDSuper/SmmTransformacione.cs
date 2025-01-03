using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmTransformacione
{
    public int SmmTransformacionId { get; set; }

    public int? IdUsuario { get; set; }

    public int? SiteId { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Subtipo { get; set; }

    public string? Comentario { get; set; }

    public int? Estado { get; set; }
}
