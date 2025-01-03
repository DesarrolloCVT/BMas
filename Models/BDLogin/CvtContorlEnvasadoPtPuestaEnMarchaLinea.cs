using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtContorlEnvasadoPtPuestaEnMarchaLinea
{
    public int IdPuestaEnMarchaLinea { get; set; }

    public short? TieneFilmAmano { get; set; }

    public short? CambioTeflones { get; set; }

    public short? CambioNicrones { get; set; }

    public short? ParadaEmergencia { get; set; }

    public short? ProteccionesFuncionando { get; set; }

    public short? FijacionesdeBigote { get; set; }

    public short? FijacionesConoAlimentador1 { get; set; }

    public short? FijacionesConoAlimentador2 { get; set; }

    public short? FijacionCopaTubo1 { get; set; }

    public short? FijacionCopaTubo2 { get; set; }

    public int? IdControlEnvPt { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
