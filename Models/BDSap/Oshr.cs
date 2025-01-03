using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oshr
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public short? UserSign { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? TemplateId { get; set; }
}
