using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTransferenciaRechazo
{
    public int RechazoId { get; set; }

    public int PackageId { get; set; }

    public int TransferId { get; set; }

    public string Motivo { get; set; } = null!;

    public int PackageQuantity { get; set; }

    public int ArticleProviderId { get; set; }

    public string? Usuario { get; set; }
}
