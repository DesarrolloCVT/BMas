using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1PaymentsView
{
    public string? DocType { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? CancelDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public DateTime? VatDate { get; set; }

    public int DocNum { get; set; }

    public int? Series { get; set; }

    public string? DocCurr { get; set; }

    public decimal? DocRate { get; set; }

    public int? FinncPriod { get; set; }

    public string? Canceled { get; set; }

    public string? JrnlMemo { get; set; }

    public string? TransCode { get; set; }

    public int DocEntry { get; set; }

    public string? ObjType { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? ResidenNum { get; set; }

    public string? OperatCode { get; set; }

    public string? PayToCode { get; set; }

    public string? Address { get; set; }

    public int? Cig { get; set; }

    public int? Cup { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public string? Comments { get; set; }
}
