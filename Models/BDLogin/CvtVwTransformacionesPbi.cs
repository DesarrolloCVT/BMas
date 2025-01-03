using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwTransformacionesPbi
{
    public int Folio { get; set; }

    public string? Bodega { get; set; }

    public string? ProcRelacionado { get; set; }

    public DateTime Fecha { get; set; }

    public string? Expr1 { get; set; }

    public string? SubTipo { get; set; }

    public string? Entidad { get; set; }

    public string? StaffUserName { get; set; }

    public string? Comentario { get; set; }

    public string? Estado { get; set; }
}
