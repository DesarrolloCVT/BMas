using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtFilmExpedicion
{
    public int ExpFilmId { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? ExpFilmDateOut { get; set; }

    public string? ExpFilmNote { get; set; }

    public int? ExpFilmStatus { get; set; }

    public DateTime? ExpFilmDateIn { get; set; }

    public int? ExpFilmTipoDocSap { get; set; }

    public int? ExpFilmNumDocSap { get; set; }

    public int? ExpFilmMotivo { get; set; }

    public int? SiteId { get; set; }
}
