using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ahf1
{
    public int AbsEntry { get; set; }

    public int? FuncId { get; set; }

    public string? FormNum { get; set; }

    public string? ItemUid { get; set; }

    public string? ColUid { get; set; }

    public string? HideVal { get; set; }

    public string? AltVal { get; set; }

    public short? PanelId { get; set; }

    public short? ActionType { get; set; }

    public short? UserSign { get; set; }

    public string? DataSource { get; set; }

    public string? Transfered { get; set; }

    public short? Instance { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
