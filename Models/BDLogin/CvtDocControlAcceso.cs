using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtDocControlAcceso
{
    public int DocControlAccesoId { get; set; }

    public int ControlAccesoId { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string NumDocumento { get; set; } = null!;

    public string? Comentario { get; set; }

    public byte[]? Documento { get; set; }

    public DateTime Fecha { get; set; }

    public string? Extencion { get; set; }

    public string? Mime { get; set; }
}
