using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtFilmExpedicionDetalle
{
    public int SiteId { get; set; }

    public int ExpFilmId { get; set; }

    public int Nbobina { get; set; }

    public int? IdUsuario { get; set; }

    public decimal? ExpFilmQuantity { get; set; }

    public DateTime? ExpFilmFechConfirm { get; set; }

    public string? ExpFilmLote { get; set; }

    public int? ExpFilmEstado { get; set; }
}
