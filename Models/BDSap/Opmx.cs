using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opmx
{
    public int AbsEntry { get; set; }

    public decimal? Total { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public string Uid { get; set; } = null!;

    public string? Rfc { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? FileDate { get; set; }

    public string? FileName { get; set; }

    public int? JvbatchNum { get; set; }

    public int? JvtransId { get; set; }

    public int? JetransId { get; set; }

    public string? Type { get; set; }
}
