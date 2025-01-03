using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otpw
{
    public int AbsEntry { get; set; }

    public int? WizNumber { get; set; }

    public string WizName { get; set; } = null!;

    public string? WizStatus { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? SaveDate { get; set; }

    public DateTime? ExecDate { get; set; }

    public short? UserSign { get; set; }

    public int? Series { get; set; }

    public int? JetransId { get; set; }

    public DateTime? WizDate { get; set; }

    public int? Rg23apart2 { get; set; }

    public int? Rg23cpart2 { get; set; }

    public short? SeqCode { get; set; }

    public int? Serial { get; set; }

    public string? SeriesStr { get; set; }

    public string? SubStr { get; set; }
}
