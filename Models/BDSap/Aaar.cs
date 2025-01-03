using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aaar
{
    public int AbsEntry { get; set; }

    public int? AuthrId { get; set; }

    public int? SubsttId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public int? WtmCode { get; set; }

    public string? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public int? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? Applied { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }
}
