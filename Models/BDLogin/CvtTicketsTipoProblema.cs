using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTicketsTipoProblema
{
    public int IdTipoProblema { get; set; }

    public int? IdCategoriaTicket { get; set; }

    public string? NombreProblema { get; set; }
}
