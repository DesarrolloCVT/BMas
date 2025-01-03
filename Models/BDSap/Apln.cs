﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Apln
{
    public short ListNum { get; set; }

    public string ListName { get; set; } = null!;

    public short? BaseNum { get; set; }

    public decimal? Factor { get; set; }

    public short? RoundSys { get; set; }

    public short? GroupCode { get; set; }

    public string? DataSource { get; set; }

    public int? Sppcounter { get; set; }

    public short? UserSign { get; set; }

    public string? IsGrossPrc { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? ValidFor { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? PrimCurr { get; set; }

    public string? AddCurr1 { get; set; }

    public string? AddCurr2 { get; set; }

    public string? RoundRule { get; set; }

    public decimal? ExtAmount { get; set; }

    public string? RndFrmtInt { get; set; }

    public string? RndFrmtDec { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
