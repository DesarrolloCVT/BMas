using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCaProveedoresNacionale
{
    public int CaPnId { get; set; }

    public string CardCode { get; set; } = null!;

    public int Oc { get; set; }

    public string Empresa { get; set; } = null!;

    public int TipoDocumento { get; set; }

    public int NumeroDocumento { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime? FechaSalida { get; set; }

    public string? Comentario { get; set; }

    public string Usuario { get; set; } = null!;
}
