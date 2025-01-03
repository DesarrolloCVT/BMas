using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dut1
{
    public string TermCode { get; set; } = null!;

    public int LevelNum { get; set; }

    public string? LetterFrmt { get; set; }

    public string? EffctAftr { get; set; }

    public decimal? LetterFee { get; set; }

    public string? FeeCurr { get; set; }

    public decimal? MinBalance { get; set; }

    public string? MinBlnCurr { get; set; }

    public string? CalcIntrst { get; set; }
}
