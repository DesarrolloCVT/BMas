using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPresupuestoCliente
{
    public int Mes { get; set; }

    public int Año { get; set; }

    public int CodVendedor { get; set; }

    public string CodCliente { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public int Cantidad { get; set; }

    public int Id { get; set; }
}
