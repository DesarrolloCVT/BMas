using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCheckListArmadoPedido
{
    public int PedidoId { get; set; }

    public DateTime FechaEntrega { get; set; }

    public bool Fefo { get; set; }

    public bool VidaUtil { get; set; }

    public bool EstadoPallet { get; set; }

    public bool Film { get; set; }

    public bool BaseProducto { get; set; }

    public bool Dun14 { get; set; }

    public int StaffId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string LugarArmado { get; set; } = null!;

    public string? Observasiones { get; set; }
}
