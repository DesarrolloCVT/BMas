using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocfl
{
    public int Code { get; set; }

    public DateTime? DateId { get; set; }

    public string? Dscription { get; set; }

    public string? Project { get; set; }

    public decimal? Credit { get; set; }

    public string? CredCur { get; set; }

    public decimal? Debit { get; set; }

    public string? DebCur { get; set; }

    public short? SecLevel { get; set; }

    public short UserId { get; set; }

    public string? Frequency { get; set; }

    public short? Remind { get; set; }

    public DateTime? EndDate { get; set; }

    public string? OcrCode { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }
}
