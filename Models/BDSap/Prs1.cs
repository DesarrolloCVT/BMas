using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Prs1
{
    public int SeqId { get; set; }

    public short LineNum { get; set; }

    public int? ObjectId { get; set; }

    public string? LaytCode { get; set; }

    public short? NumCopy { get; set; }

    public int? UsrQuery { get; set; }

    public short? SubDocType { get; set; }

    public string? Printer { get; set; }

    public string? Prtr1st { get; set; }

    public string? Use1stPrtr { get; set; }
}
