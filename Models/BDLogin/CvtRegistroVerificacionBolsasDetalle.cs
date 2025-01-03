using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroVerificacionBolsasDetalle
{
    public int IdVerificacionBolsasDetalle { get; set; }

    public int IdVerificacionBolsas { get; set; }

    public TimeOnly Hora { get; set; }

    public short FechaElaboracion { get; set; }

    public short FechaVencimiento { get; set; }

    public short LoteCorrecto { get; set; }

    public short HoraEnvasadoCorrecto { get; set; }

    public short TurnoCorrecto { get; set; }

    public short LineaCorrecta { get; set; }

    public short OrigenIndicadoInjeckt { get; set; }

    public short SelloHorizontal { get; set; }

    public short SelloVertical { get; set; }

    public short FechaElaboracionLote { get; set; }

    public short CodigoBarraEan13 { get; set; }

    public short CodigoBarraDun14 { get; set; }

    public string? Observacion { get; set; }

    public short? SelloVertiContenedora { get; set; }

    public short? SelloHorizContenedora { get; set; }
}
