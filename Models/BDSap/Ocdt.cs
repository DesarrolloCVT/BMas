using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocdt
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? TermType { get; set; }

    public short? AfterDays { get; set; }

    public short? AfterMnth { get; set; }

    public short? DayFrom1 { get; set; }

    public short? DayTo1 { get; set; }

    public short? PayDay1 { get; set; }

    public short? PayMonth1 { get; set; }

    public short? DayFrom2 { get; set; }

    public short? DayTo2 { get; set; }

    public short? PayDay2 { get; set; }

    public short? PayMonth2 { get; set; }

    public short? DayFrom3 { get; set; }

    public short? DayTo3 { get; set; }

    public short? PayDay3 { get; set; }

    public short? PayMonth3 { get; set; }

    public short? DayFrom4 { get; set; }

    public short? DayTo4 { get; set; }

    public short? PayDay4 { get; set; }

    public short? PayMonth4 { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
