using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Bot1
{
    public int AbsEntry { get; set; }

    public int Boenumber { get; set; }

    public string BoeType { get; set; } = null!;

    public DateTime? DueDate { get; set; }

    public string? BpbankCtr { get; set; }

    public string? BpbankCod { get; set; }

    public string? BpbankAct { get; set; }

    public string? BpbankBrnc { get; set; }

    public int? ExReconNum { get; set; }

    public int? Boeabs { get; set; }

    public int? Bplid { get; set; }

    public string? EnBpbnkAct { get; set; }

    public string? EncryptIv { get; set; }

    public string? Dppstatus { get; set; }
}
