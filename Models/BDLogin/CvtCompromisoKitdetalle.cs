using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCompromisoKitdetalle
{
    public int CkitId { get; set; }

    public int CkitdetId { get; set; }

    public string Itemcode { get; set; } = null!;

    public decimal Cantidad { get; set; }
}
