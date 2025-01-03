using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtMaquinaComponente
{
    public int Id { get; set; }

    public string Descricion { get; set; } = null!;

    public int PadreId { get; set; }
}
