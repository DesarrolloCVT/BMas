using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oecdw
{
    public int AbsEntry { get; set; }

    public string? RunName { get; set; }

    public DateTime? RunDate { get; set; }

    public short? RunTime { get; set; }

    public string? Status { get; set; }

    public int? UserSign { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public string? DecenInd { get; set; }

    public int? Branch { get; set; }

    public string? InstCode { get; set; }

    public string? EntIdCode { get; set; }

    public string? SituatInd { get; set; }

    public string? ReportType { get; set; }

    public string? CmpName { get; set; }

    public string? CmpState { get; set; }

    public string? CmpCntCode { get; set; }

    public string? CmpCnpj { get; set; }

    public string? CmpIe { get; set; }

    public string? CmpCity { get; set; }

    public string? BrnState { get; set; }

    public string? BrnCntCode { get; set; }

    public string? BrnCnpj { get; set; }

    public string? BrnIe { get; set; }

    public string? BrnCity { get; set; }

    public string? AccStIden { get; set; }

    public string? AccStRem { get; set; }

    public string? BookPurp { get; set; }

    public int? JrnlNum { get; set; }

    public string? PeriodSitu { get; set; }

    public string? BkPrpsInd { get; set; }

    public string? Nireind { get; set; }

    public string? SubBkNire { get; set; }

    public string? SubBkHash { get; set; }

    public int? BalanTemp { get; set; }

    public int? PrLosTemp { get; set; }

    public string? BalanRefF { get; set; }

    public string? BalanUdfF { get; set; }

    public string? PrLosRefF { get; set; }

    public string? PrLosUdfF { get; set; }
}
