using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odar
{
    public int AbsEntry { get; set; }

    public DateTime? PeriodDate { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public int? VersionNum { get; set; }

    public string? JeperLen { get; set; }

    public string? Jeref1 { get; set; }

    public string? Jeref2 { get; set; }

    public string? Jememo { get; set; }

    public string? JebyProj { get; set; }

    public string? JebyProf { get; set; }

    public string? InperLen { get; set; }

    public short? InpriceSrc { get; set; }

    public string? Inref1 { get; set; }

    public string? Inref2 { get; set; }

    public string? Inmemo { get; set; }

    public string? JebyCurr { get; set; }

    public string? JebyDim2 { get; set; }

    public string? JebyDim3 { get; set; }

    public string? JebyDim4 { get; set; }

    public string? JebyDim5 { get; set; }

    public decimal? Dbreduc { get; set; }

    public decimal? DbreducPer { get; set; }

    public int? TrandReduc { get; set; }

    public decimal? TranReducP { get; set; }

    public string? InzeroPrc { get; set; }

    public decimal? TranRedArP { get; set; }

    public string? DelNonReco { get; set; }

    public string? RunName { get; set; }

    public string? Rodbguid { get; set; }

    public string? ArchMethod { get; set; }
}
