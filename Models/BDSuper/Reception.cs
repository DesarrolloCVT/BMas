using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class Reception
{
    public int SiteId { get; set; }

    public int ReceptionId { get; set; }

    public string CardCode { get; set; } = null!;

    public int IdUsuario { get; set; }

    public string DocType { get; set; } = null!;

    public int ReceptionDocNumber { get; set; }

    public DateTime ReceptionDateIn { get; set; }

    public DateTime? ReceptionDateOut { get; set; }

    public string? ReceptionNote { get; set; }

    public int ReceptionStatus { get; set; }

    public int? ReceptionType { get; set; }

    public int? TipoDocSap { get; set; }

    public int? NumDocSap { get; set; }
}
