using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVentasDatosProducto
{
    public string ItemCode { get; set; } = null!;

    public int Upc { get; set; }

    public int Palletizado { get; set; }

    public int BasePallet { get; set; }

    public int MedioAdicional { get; set; }

    public int BaseAdicional { get; set; }

    public int SmallAdicional { get; set; }
}
