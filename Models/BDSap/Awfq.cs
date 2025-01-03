using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awfq
{
    public int SequenceId { get; set; }

    public string? SourceDb { get; set; }

    public string? Timestamp { get; set; }

    public string? ObjectType { get; set; }

    public string? TransType { get; set; }

    public int? FieldsInKe { get; set; }

    public string? FieldNames { get; set; }

    public string? FieldValue { get; set; }

    public string? UserId { get; set; }

    public string? TaskId { get; set; }

    public string? TrigEvntId { get; set; }

    public string? TrigParams { get; set; }

    public int LogInst { get; set; }

    public string? IsSuccess { get; set; }

    public string? ResultMemo { get; set; }
}
