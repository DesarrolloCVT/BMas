using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ogpa
{
    public int AbsEntry { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? WizType { get; set; }

    public int? NGpadj { get; set; }

    public int? NPcadj { get; set; }

    public int? NGpfail { get; set; }

    public int? NPcfail { get; set; }

    public int? NJecreate { get; set; }

    public int? NMrvcreate { get; set; }
}
