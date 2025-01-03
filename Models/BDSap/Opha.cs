using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opha
{
    public int AbsEntry { get; set; }

    public int? Owner { get; set; }

    public string? Name { get; set; }

    public DateTime? Start { get; set; }

    public decimal? Finished { get; set; }

    public int? ParentId { get; set; }

    public int? ProjectId { get; set; }

    public int? Code { get; set; }

    public int? Typ { get; set; }

    public decimal? Contrib { get; set; }

    public string? Status { get; set; }

    public DateTime? End { get; set; }

    public decimal? Cost { get; set; }

    public decimal? Planned { get; set; }

    public int? Level { get; set; }

    public DateTime? Duedate { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? UpdateTs { get; set; }
}
