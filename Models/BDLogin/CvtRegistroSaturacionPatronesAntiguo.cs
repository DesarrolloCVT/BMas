using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroSaturacionPatronesAntiguo
{
    public int IdSaturacionPatronesAntiguo { get; set; }

    public int IdUsuario { get; set; }

    public string ItemCode { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public TimeOnly HoraRegistro { get; set; }

    public int? Pasadas { get; set; }

    public short? Fe15mm { get; set; }

    public short? NoFe25mm { get; set; }

    public short? DetectaAcero { get; set; }

    public short? Enciendebaliza { get; set; }

    public short? SuenaBaliza { get; set; }

    public short? FuncionaBrazo { get; set; }

    public DateTime? FechaIngresoRegistro { get; set; }

    public string? Observacion { get; set; }
}
