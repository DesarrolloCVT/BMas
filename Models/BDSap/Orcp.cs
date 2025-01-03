using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orcp
{
    public int AbsEntry { get; set; }

    public string? Code { get; set; }

    public string? Dscription { get; set; }

    public string? IsRemoved { get; set; }

    public string? DocObjType { get; set; }

    public int? DraftEntry { get; set; }

    public string? Frequency { get; set; }

    public short? Remind { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? LogInstanc { get; set; }

    public short? CreateUser { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UpdateTime { get; set; }

    public string? DataSource { get; set; }

    public string? PriceUpdat { get; set; }

    public string? CardCode { get; set; }
}
