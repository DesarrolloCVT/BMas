﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Abfc
{
    public int AbsEntry { get; set; }

    public string? FldType { get; set; }

    public short? FldNum { get; set; }

    public string? DispName { get; set; }

    public string? Activated { get; set; }

    public short? UserSign { get; set; }

    public string? DataSource { get; set; }

    public string? Transfered { get; set; }

    public short? Instance { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DftName { get; set; }
}