using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTransformacion
{
    public int TransformacionId { get; set; }

    public int StaffId { get; set; }

    public int SiteId { get; set; }

    public DateTime Fecha { get; set; }

    public int Tipo { get; set; }

    public int SubTipo { get; set; }

    public int? Entidad { get; set; }

    public int? Folio { get; set; }

    public string? Comentario { get; set; }

    public int Estado { get; set; }

    public string? ProcRelacionado { get; set; }
}
