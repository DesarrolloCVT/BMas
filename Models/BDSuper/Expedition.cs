using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class Expedition
{
    public int SiteId { get; set; }

    public int ExpeditionId { get; set; }

    public int IdUsuario { get; set; }

    public DateTime? ExpeditionDateOut { get; set; }

    public string? ExpeditionNote { get; set; }

    public int ExpeditionStatus { get; set; }

    public DateTime? ExpeditionDateIn { get; set; }

    public int? ExpeditionTipoDocSap { get; set; }

    public int? ExpeditionNumDocSap { get; set; }

    public int? ExpeditionMotivo { get; set; }
}
