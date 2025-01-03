using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1NlauditFileOpeningDocView
{
    public int? TransId { get; set; }

    public string? ObjType { get; set; }

    public int DocEntry { get; set; }

    public string CardCode { get; set; } = null!;

    public string? CardType { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? DocDueDate { get; set; }

    public string? Comments { get; set; }
}
