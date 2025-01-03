using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlEnvasadoPtControlPesoLinea
{
    public int IdControlEnvasadoPtContPeso { get; set; }

    public int? IdControlEnvPt { get; set; }

    public int? Linea { get; set; }

    public TimeOnly? Hora { get; set; }

    public DateTime? FechaElaboracion { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public short? SelloHorizontal { get; set; }

    public short? SelloVertical { get; set; }

    public short? OrigenInjet { get; set; }

    public short? OrigenImpreso { get; set; }

    public short? HoraCorrecta { get; set; }

    public short? LoteCorrecto { get; set; }

    public short? TurnoCorrecto { get; set; }

    public int? Vaso1 { get; set; }

    public int? Vaso2 { get; set; }

    public int? Vaso3 { get; set; }

    public int? Vaso4 { get; set; }

    public short CodBarraBolsa { get; set; }

    public short CodBarraContenedora { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuario { get; set; }
}
