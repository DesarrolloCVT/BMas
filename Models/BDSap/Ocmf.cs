using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocmf
{
    public short UserId { get; set; }

    public int ItemIndex { get; set; }

    public string? MenuUid { get; set; }

    public short? GroupId { get; set; }

    public string? MenuType { get; set; }

    public string? CmfMenuId { get; set; }
}
