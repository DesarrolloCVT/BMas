using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oirc
{
    public int CategoryId { get; set; }

    public int? ParentId { get; set; }

    public string? Name { get; set; }

    public string? ResKey { get; set; }

    public string? Comment { get; set; }

    public string? System { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? ModifyDate { get; set; }
}
