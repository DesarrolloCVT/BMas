using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Atc1
{
    public int AbsEntry { get; set; }

    public int Line { get; set; }

    public string? SrcPath { get; set; }

    public string? TrgtPath { get; set; }

    public string? FileName { get; set; }

    public string? FileExt { get; set; }

    public DateTime? Date { get; set; }

    public int? UsrId { get; set; }

    public string? Copied { get; set; }

    public string? Override { get; set; }

    public string? SubPath { get; set; }

    public string? FreeText { get; set; }

    public string? CopyToTrgt { get; set; }

    public string? CopyToProd { get; set; }
}
