using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class ImpresionEtiqueta
{
    public int IdImpresion { get; set; }

    public int StaffId { get; set; }

    public int Numero { get; set; }

    public int Tipo { get; set; }

    public DateTime Fecha { get; set; }
}
