using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gpa2
{
    public int AbsEntry { get; set; }

    public string? Name { get; set; }

    public string? Descript { get; set; }

    public DateTime? PostDateFr { get; set; }

    public DateTime? PostDateTo { get; set; }

    public string? ItemCodeFr { get; set; }

    public string? ItemCodeTo { get; set; }

    public short? ItmsGrpCod { get; set; }

    public string? AdditFilt { get; set; }

    public string? SearchCond { get; set; }

    public string? PropList { get; set; }

    public string? DisplInact { get; set; }

    public string? UseGroups { get; set; }
}
