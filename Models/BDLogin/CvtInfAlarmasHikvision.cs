using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfAlarmasHikvision
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public string? Modelo { get; set; }

    public int? Marca { get; set; }

    public string? Serie { get; set; }

    public string? Usuario { get; set; }

    public string? Contraseña { get; set; }

    public string? AccesoIp { get; set; }

    public string? Mac { get; set; }

    public string? Firmware { get; set; }

    public string? Area { get; set; }

    public string? Zona { get; set; }

    public string? UbicacionFisica { get; set; }

    public string? Codificacion { get; set; }

    public int? Estado { get; set; }
}
