using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oudo
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string TableName { get; set; } = null!;

    public string? LogTable { get; set; }

    public string? Type { get; set; }

    public string? MngSeries { get; set; }

    public string? CanDelete { get; set; }

    public string? CanClose { get; set; }

    public string? CanCancel { get; set; }

    public string? ExtName { get; set; }

    public string? CanFind { get; set; }

    public string? CanYrTrnsf { get; set; }

    public string? CanDefForm { get; set; }

    public string? CanLog { get; set; }

    public string? OvrWrtDll { get; set; }

    public string? Uidformat { get; set; }

    public string? CanArchive { get; set; }

    public string? MenuItem { get; set; }

    public string? MenuCapt { get; set; }

    public int? FatherMenu { get; set; }

    public short? Position { get; set; }

    public string? CanNewForm { get; set; }

    public string? IsRebuild { get; set; }

    public string? NewFormSrf { get; set; }

    public string? MenuUid { get; set; }

    public DateTime? LstUpdDate { get; set; }

    public int? LstUpdTime { get; set; }

    public string? CanApprove { get; set; }

    public int? TemplateId { get; set; }
}
