using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opmg
{
    public int AbsEntry { get; set; }

    public int? Owner { get; set; }

    public string? Name { get; set; }

    public DateTime? Start { get; set; }

    public decimal? Finished { get; set; }

    public int? DocNum { get; set; }

    public int? Series { get; set; }

    public string? Typ { get; set; }

    public string? Cardcode { get; set; }

    public string? Cardname { get; set; }

    public int? Contact { get; set; }

    public int? Territory { get; set; }

    public int? Employee { get; set; }

    public string? WithPhases { get; set; }

    public string? Status { get; set; }

    public DateTime? Duedate { get; set; }

    public DateTime? Closing { get; set; }

    public string? Fiproject { get; set; }

    public string? Risk { get; set; }

    public int? Industry { get; set; }

    public string? Reason { get; set; }

    public string? FreeText { get; set; }

    public int? Bplid { get; set; }

    public int? AtcEntry { get; set; }

    public string? Attachment { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? UpdateTs { get; set; }

    public string? Dppstatus { get; set; }

    public string? EncryptIv { get; set; }
}
