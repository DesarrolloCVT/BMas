using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmComisionVendedor
{
    public int IdVendedor { get; set; }

    public int IdGrupoProd { get; set; }

    public int? IdSubFamilia { get; set; }

    public int? Comision { get; set; }
}
