using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwListTransfer
{
    public int SiteId { get; set; }

    public int TransferId { get; set; }

    public int SiteIdDestiny { get; set; }

    public int IdUsuario { get; set; }

    public int? CantidadPallet { get; set; }
}
