using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1PaymentsByPayMeansView
{
    public string? ObjType { get; set; }

    public int AbsEntry { get; set; }

    public int Num { get; set; }

    public string? Type { get; set; }

    public string? Cancelled { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public DateTime? VatDate { get; set; }

    public decimal? Total { get; set; }

    public string? Currency { get; set; }

    public int? Branch { get; set; }

    public string? OperationCode { get; set; }

    public string? CardCode { get; set; }

    public int DocPayMeansType { get; set; }

    public int DocPayMeansLineId { get; set; }

    public int? DocPayMeansId { get; set; }

    public string? DocObjType { get; set; }

    public int? DocAbsEntry { get; set; }

    public int DocTransId { get; set; }

    public int? DocPayMeansNum { get; set; }

    public string? DocPayMeansNumStr { get; set; }

    public decimal? DocPayMeansSum { get; set; }

    public int DocPayMeansVat { get; set; }
}
