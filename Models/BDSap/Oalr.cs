using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oalr
{
    public int Code { get; set; }

    public string? Type { get; set; }

    public string? Priority { get; set; }

    public int? Tcode { get; set; }

    public string? Subject { get; set; }

    public string? UserText { get; set; }

    public int? DataCols { get; set; }

    public string? DataParams { get; set; }

    public string? MsgData { get; set; }

    public short? UserSign { get; set; }

    public string? Attachment { get; set; }

    public string? DataSource { get; set; }

    public int? AtcEntry { get; set; }

    public string? AltType { get; set; }
}
