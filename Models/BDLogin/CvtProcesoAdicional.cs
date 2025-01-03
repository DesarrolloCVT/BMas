using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtProcesoAdicional
{
    public int ProcesoAdicionalId { get; set; }

    public DateTime Fecha { get; set; }

    public int StaffId { get; set; }

    public string? Comentario { get; set; }

    public string? Supervisor { get; set; }

    public int? CantidadPersonas { get; set; }

    public int Estado { get; set; }

    public int? TransferenciaId { get; set; }

    public int TipoServicioAdicionalId { get; set; }
}
