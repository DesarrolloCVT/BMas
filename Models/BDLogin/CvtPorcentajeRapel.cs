using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPorcentajeRapel
{
    public DateTime FechaInicio { get; set; }

    public string CardCode { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public decimal? PastaColiseo { get; set; }

    public decimal? LaColiseoCm { get; set; }

    public decimal? LaColiseoW { get; set; }

    public decimal? LaMmppW { get; set; }

    public decimal? Centralizacion { get; set; }

    public decimal? Merma { get; set; }

    public decimal? DistribCentMmpp { get; set; }

    public decimal? DistribCentRestSurtido { get; set; }

    public decimal? ExtranetRestSurtido { get; set; }

    public decimal? RebateFijo { get; set; }

    public decimal? ReposicionIntSellOut { get; set; }

    public decimal? NoDevolucion { get; set; }

    public decimal? Pel { get; set; }

    public decimal? CobroFianza { get; set; }

    public DateTime? FechaTermino { get; set; }

    public decimal? TotalRapel { get; set; }

    public string? FamiliaProducto { get; set; }
}
