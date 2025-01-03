using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odp
{
    public int DeposId { get; set; }

    public string? DeposType { get; set; }

    public int DeposNum { get; set; }

    public DateTime? DeposDate { get; set; }

    public string? DeposCurr { get; set; }

    public string? BanckAcct { get; set; }

    public string? DeposAcct { get; set; }

    public string? DeposBrnch { get; set; }

    public string? Memo { get; set; }

    public decimal? LocTotal { get; set; }

    public decimal? FcTotal { get; set; }

    public decimal? SysTotal { get; set; }

    public int? TransAbs { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public short? DocTime { get; set; }

    public string? AllocAcct { get; set; }

    public string? ChkType { get; set; }

    public string? DpsBank { get; set; }

    public string? DpostorNam { get; set; }

    public string? Printed { get; set; }

    public decimal? DocRate { get; set; }

    public string? CrdBankAct { get; set; }

    public string? IsCard { get; set; }

    public string? Transfered { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Splited { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? VatAct { get; set; }

    public string? ComissAct { get; set; }

    public decimal? VatTotal { get; set; }

    public decimal? Comission { get; set; }

    public DateTime? ComissDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public int Series { get; set; }

    public string? DataSource { get; set; }

    public string? ObjType { get; set; }

    public int? FinncPriod { get; set; }

    public decimal? VatTotlSys { get; set; }

    public decimal? ComissnSys { get; set; }

    public short? UserSign { get; set; }

    public string? DepostNorm { get; set; }

    public string? PostType { get; set; }

    public string? BankCountr { get; set; }

    public string? Canceled { get; set; }

    public int? CnclDps { get; set; }

    public string? CommisVat { get; set; }

    public short? SeqCode { get; set; }

    public int? Serial { get; set; }

    public string? SeriesStr { get; set; }

    public string? SubStr { get; set; }

    public string? Project { get; set; }

    public string? ReconAfter { get; set; }

    public string? OcrCode { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public decimal? ComisFc { get; set; }

    public decimal? VatTotlFc { get; set; }

    public string? ComisCurr { get; set; }

    public string? SupplCode { get; set; }

    public int? Bplid { get; set; }

    public decimal? SysRate { get; set; }

    public int? AtcEntry { get; set; }

    public string? Attachment { get; set; }

    public string? IncomeAct { get; set; }

    public decimal? IncomeLc { get; set; }

    public decimal? IncomeFc { get; set; }

    public decimal? IncomeSc { get; set; }

    public int? UpdateTs { get; set; }
}
