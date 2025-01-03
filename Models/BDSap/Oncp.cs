using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oncp
{
    public int AbsEntry { get; set; }

    public string Name { get; set; } = null!;

    public int Owner { get; set; }

    public int? GroupId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? IsPublic { get; set; }

    public string? Pubby { get; set; }

    public DateTime? PubDate { get; set; }

    public string? Type { get; set; }

    public string? Descr { get; set; }

    public DateTime? Date { get; set; }

    public short? Time { get; set; }

    public string? Mnfacturer { get; set; }
}
