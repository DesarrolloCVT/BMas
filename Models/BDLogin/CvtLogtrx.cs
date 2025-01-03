using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLogtrx
{
    public int Idtrx { get; set; }

    public string Tabla { get; set; } = null!;

    public string Columna { get; set; } = null!;

    public int ValorKey { get; set; }

    public string ValorPrevio { get; set; } = null!;

    public string ValorNuevo { get; set; } = null!;

    public short IdAccion { get; set; }

    public string IdUserPc { get; set; } = null!;

    public string IdNombrePc { get; set; } = null!;

    public string IdDirIp { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }
}
