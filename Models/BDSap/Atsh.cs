using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Atsh
{
    public int AbsEntry { get; set; }

    public int? ProjectId { get; set; }

    public int? DocNum { get; set; }

    public string? Type { get; set; }

    public int? UserId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public short? Department { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? UpdateTs { get; set; }

    public string? Dppstatus { get; set; }

    public string? Sappassprt { get; set; }

    public string? EncryptIv { get; set; }

    public int? AtcEntry { get; set; }

    public string? Attachment { get; set; }

    public string? UserCode { get; set; }

    public int? DataVers { get; set; }
}
