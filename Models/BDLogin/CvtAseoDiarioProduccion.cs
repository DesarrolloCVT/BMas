using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAseoDiarioProduccion
{
    public int AseoddiarioId { get; set; }

    public int Of { get; set; }

    public bool BarridoPisoSala { get; set; }

    public bool SoplarMaquina { get; set; }

    public bool SacosBarridoAmarradosPesados { get; set; }

    public bool SacosReenvasadoAmarradosPesados { get; set; }

    public int Verificador { get; set; }

    public DateTime FechaVerificacion { get; set; }

    public string? Observaciones { get; set; }
}
