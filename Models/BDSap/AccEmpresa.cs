using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class AccEmpresa
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UGiro { get; set; }

    public string? UActEco { get; set; }

    public string? URutEnvia { get; set; }

    public DateTime? UFchResol { get; set; }

    public string? UResolucion { get; set; }

    public string? UPathFiles { get; set; }

    public string? UPathBook { get; set; }

    public string? UPathPdf { get; set; }

    public string? UImpresora { get; set; }

    public string? UDirWs { get; set; }

    public string? UMailcopiaDte { get; set; }

    public string? UObservaciones { get; set; }

    public string? URutEmisor { get; set; }
}
