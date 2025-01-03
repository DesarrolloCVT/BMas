using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTransferenciaTiempoCierre
{
    public int? Dia { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime? TransferUFechaCierre { get; set; }

    public int? Horas { get; set; }

    public string? Usuario { get; set; }

    public string? Origen { get; set; }

    public string? Destino { get; set; }
}
