using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlEnvasadoPtAseoDiario
{
    public int IdAseoDiarioPt { get; set; }

    public int? IdControlEnvPt { get; set; }

    public short? BarridoPisoSala { get; set; }

    public short? SoplarMaquina { get; set; }

    public short? SacosDeBarrido { get; set; }

    public short? PesadosAmarrados { get; set; }

    public short? SacosReenvasado { get; set; }

    public DateTime? FechaVerificacion { get; set; }

    public int? Verificador { get; set; }

    public string? Observaciones { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
