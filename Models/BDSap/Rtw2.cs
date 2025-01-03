using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rtw2
{
    public int AbsEntry { get; set; }

    public int? SequenceNo { get; set; }

    public DateTime? StampDate { get; set; }

    public string? RetFile { get; set; }

    public string? Format { get; set; }

    public string? BankCode { get; set; }

    public string? Account { get; set; }

    public string? RunType { get; set; }

    public int? RunRecords { get; set; }

    public string? ImCardName { get; set; }

    public DateTime? PostDate { get; set; }
}
