using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Atsp
{
    public int AbsEntry { get; set; }

    public string? TransCode { get; set; }

    public string? TransName { get; set; }

    public string? TransId { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? DataSource { get; set; }
}
