using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ortw
{
    public int AbsEntry { get; set; }

    public DateTime? WdueDtFrom { get; set; }

    public DateTime? WdueDtTo { get; set; }

    public string? WimpFile { get; set; }

    public int? Wmatching { get; set; }

    public int? WboletosAu { get; set; }

    public int? WboletosMn { get; set; }

    public int? WboletosNi { get; set; }

    public DateTime? WrelDate { get; set; }

    public int? WcollDisc { get; set; }

    public string? WbankAcc1 { get; set; }

    public string? WbankAcc2 { get; set; }

    public string? WfileForm2 { get; set; }
}
