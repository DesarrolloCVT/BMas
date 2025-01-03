using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ouqr
{
    public int IntrnalKey { get; set; }

    public int Qcategory { get; set; }

    public string Qname { get; set; } = null!;

    public string? Qstring { get; set; }

    public string? Qtype { get; set; }

    public string? ColumnSize { get; set; }

    public int? Dbtype { get; set; }

    public DateTime? QlastDate { get; set; }

    public short? QlastTime { get; set; }

    public string? Xslt { get; set; }

    public string? MenuItem { get; set; }

    public string? MenuCapt { get; set; }

    public int? FatherMenu { get; set; }

    public short? MenuPos { get; set; }

    public string? MenuUid { get; set; }

    public int? CommandId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? LastUpdate { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ChangeDate { get; set; }

    public int? CreateTs { get; set; }

    public int? UpdateTs { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? AnaActive { get; set; }
}
