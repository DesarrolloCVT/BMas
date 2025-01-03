using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRutaCamion
{
    public int IdRutaCamion { get; set; }

    public string Patente { get; set; } = null!;

    public string NombreChofer { get; set; } = null!;

    public TimeOnly? HraEntrada { get; set; }

    public TimeOnly? HraSalida { get; set; }

    public short TipoVuelta { get; set; }

    public string? Destino { get; set; }

    public int? CantPeonetas { get; set; }

    public short? LlevaCarro { get; set; }

    public string? PatenteCarro { get; set; }

    public short? Traspaleta { get; set; }

    public DateOnly FechaRuta { get; set; }
}
