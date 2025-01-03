using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1AllDocumentsViewVawg
{
    public int? ObjType { get; set; }

    public DateTime? DocDate { get; set; }

    public int? DocNum { get; set; }

    public int DocEntry { get; set; }

    public int UseEffDate { get; set; }

    public string? IsCrin { get; set; }
}
