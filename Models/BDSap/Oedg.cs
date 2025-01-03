﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oedg
{
    public int AbsEntry { get; set; }

    public string Type { get; set; } = null!;

    public string? ObjType { get; set; }

    public string ObjCode { get; set; } = null!;

    public string? DiscRel { get; set; }

    public string? ValidFor { get; set; }

    public DateTime? ValidForm { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
