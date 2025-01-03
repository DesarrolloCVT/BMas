using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ossg
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public string? CustGroup { get; set; }

    public string? EnEditTime { get; set; }

    public string? EnReject { get; set; }

    public string? EnResign { get; set; }

    public string? EnFollowup { get; set; }

    public string? EnSign { get; set; }

    public string? EnStarRat { get; set; }

    public string? EnActDura { get; set; }

    public int? AdBoardId { get; set; }
}
