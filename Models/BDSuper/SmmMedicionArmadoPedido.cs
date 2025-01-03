using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmMedicionArmadoPedido
{
    public int IdMedicionArmado { get; set; }

    public int Norden { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? CodBarras { get; set; }

    public string? UniMedida { get; set; }

    public int? Cantidad { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public int? IdVerificador { get; set; }

    public string? CantCorrecta { get; set; }

    public string? VencCorrecto { get; set; }

    public string? Etiqueta { get; set; }

    public string? Enfilado { get; set; }

    public string? Estibado { get; set; }

    public string? CondPallet { get; set; }

    public int? PrcCumpl { get; set; }
}
