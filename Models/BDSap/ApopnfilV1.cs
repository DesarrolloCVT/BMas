using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class ApopnfilV1
{
    public string Modulo { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public int? IntrnMatch { get; set; }

    public string? TransType { get; set; }

    public int TransId { get; set; }

    public int? Docnum { get; set; }

    public int? CreatedBy { get; set; }

    public string? FolioPref { get; set; }

    public int? FolioNum { get; set; }

    public DateTime? Taxdate { get; set; }

    public DateTime? DocDueDate { get; set; }

    public int DiasPago { get; set; }

    public int DiasDoc { get; set; }

    public string? Edad { get; set; }

    public string Cardcode { get; set; } = null!;

    public string? CardName { get; set; }

    public short? GroupCode { get; set; }

    public string GroupName { get; set; } = null!;

    public string? Memo { get; set; }

    public decimal? MontoDoc { get; set; }

    public decimal? DocTotal { get; set; }

    public decimal? SysTotal { get; set; }

    public decimal? Fctotal { get; set; }

    public decimal? FctotalMe { get; set; }

    public string? Doccur { get; set; }

    public string? MainCurncy { get; set; }

    public string? SysCurrncy { get; set; }

    public decimal? DocRate { get; set; }

    public string? FormatCode { get; set; }

    public string? AcctName { get; set; }

    public DateTime? Refdate { get; set; }

    public string? Lictradnum { get; set; }

    public DateTime? MthDate { get; set; }

    public decimal? BalDueDeb { get; set; }

    public decimal? BalDueCred { get; set; }

    public decimal? BalFcDeb { get; set; }

    public decimal? BalFcCred { get; set; }
}
