using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwCheckListArmadoPedido
{
    public int PedidoN { get; set; }

    public string? Cliente { get; set; }

    public DateTime FechaEntrega { get; set; }

    public bool Fefo { get; set; }

    public bool VidaUtil { get; set; }

    public bool EstadoPallet { get; set; }

    public bool Film { get; set; }

    public bool BaseProducto { get; set; }

    public bool Dun14 { get; set; }

    public string LugarArmado { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string? Usuario { get; set; }

    public string? Observasiones { get; set; }
}
