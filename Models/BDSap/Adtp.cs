using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Adtp
{
    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public string? DprMeth { get; set; }

    public decimal? DprTo { get; set; }

    public string? Rounding { get; set; }

    public string? InclSalv { get; set; }

    public decimal? SalvPerc { get; set; }

    public string? PerAcq { get; set; }

    public string? PerSubAcq { get; set; }

    public string? PerRet { get; set; }

    public string? AcqPrtyp { get; set; }

    public string? SubPrtyp { get; set; }

    public string? RetPrtyp { get; set; }

    public decimal? PerDpRev { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? SCalcMeth { get; set; }

    public decimal? SPercent { get; set; }

    public string? DBase { get; set; }

    public decimal? DPercent { get; set; }

    public decimal? DFactor { get; set; }

    public string? DAltDprTyp { get; set; }

    public string? MaDecBase { get; set; }

    public string? SpMeth { get; set; }

    public int? SpConcPer { get; set; }

    public decimal? SpMaxPerc { get; set; }

    public string? SpAdDpr { get; set; }

    public string? SpAlDpr { get; set; }

    public string? PoolId { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DprPer { get; set; }

    public decimal? PerFactor { get; set; }

    public decimal? SpMaxAmnt { get; set; }

    public string? SpMaxFlag { get; set; }

    public string? CalcBase { get; set; }

    public string? DeprEndLfy { get; set; }

    public string? AccuPriorP { get; set; }

    public int? DeltaCoeff { get; set; }

    public decimal? MaxDepr { get; set; }

    public string? FactorFfy { get; set; }

    public int? SnapshotId { get; set; }

    public string? PerTranSou { get; set; }

    public string? PerTranTar { get; set; }

    public string? TranSprtyp { get; set; }

    public string? TranTprtyp { get; set; }

    public string? RoundMeth { get; set; }
}
