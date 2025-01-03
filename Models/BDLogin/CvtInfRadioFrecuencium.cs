using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfRadioFrecuencium
{
    public int Id { get; set; }

    public string? Dispositivo { get; set; }

    public int? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Ip { get; set; }

    public string? PartNumber { get; set; }

    public string? SerialNumber { get; set; }

    public string? Mac { get; set; }

    public int? SistemaOperativo { get; set; }

    public string? Ram { get; set; }

    public string? Cpu { get; set; }

    public string? FlashSize { get; set; }

    public string? Usuario { get; set; }

    public int? Area { get; set; }

    public string? UsuarioDos { get; set; }

    public string? CodAf { get; set; }

    public int? Estado { get; set; }
}
