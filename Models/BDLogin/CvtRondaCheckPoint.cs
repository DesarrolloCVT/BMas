using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRondaCheckPoint
{
    public int CheckPointId { get; set; }

    public string CheckPointLugar { get; set; } = null!;

    public string CheckPointCoordenadas { get; set; } = null!;
}
