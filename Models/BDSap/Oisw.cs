using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oisw
{
    public int AbsEntry { get; set; }

    public string? DeclDescr { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public DateTime? RunDate { get; set; }

    public string? ImpExpInd { get; set; }

    public string? Status { get; set; }

    public int? MsgType { get; set; }

    public decimal? TtlDocVal { get; set; }

    public int? DocCount { get; set; }

    public string? CompName { get; set; }

    public string? CompDeclId { get; set; }

    public string? CompStreet { get; set; }

    public string? CompCity { get; set; }

    public string? CompZip { get; set; }

    public string? CompCntry { get; set; }

    public string? DeclCntry { get; set; }

    public int? CntPersId { get; set; }

    public string? CntPerson { get; set; }

    public string? CntEmail { get; set; }

    public string? CntPhone { get; set; }

    public string? CntFax { get; set; }

    public string? VatregNo { get; set; }

    public string? VatregEx { get; set; }

    public string? DeclNum { get; set; }

    public int? DeclNoEx { get; set; }

    public int? HeaderId { get; set; }

    public string? DeclStat { get; set; }

    public short? DeclDept { get; set; }

    public string? DeclCurr { get; set; }

    public string? ObligLvl { get; set; }

    public string? TaxState { get; set; }

    public string? CustOffc { get; set; }

    public string? CustOffId { get; set; }

    public string? DeclSerNo { get; set; }

    public string? IntCtrlRef { get; set; }

    public string? Addr13p { get; set; }

    public string? Addr23p { get; set; }

    public string? Addr33p { get; set; }

    public string? Addr43p { get; set; }

    public string? CntPers3p { get; set; }

    public string? CntPhon3p { get; set; }

    public string? CntFax3p { get; set; }

    public string? FreeTxt1 { get; set; }

    public string? FreeTxt2 { get; set; }

    public string? FreeTxt3 { get; set; }

    public string? FreeTxt4 { get; set; }

    public string? FreeTxt5 { get; set; }

    public string? ValidKey { get; set; }

    public string? IsdeclOffc { get; set; }

    public string? ReleaseVer { get; set; }

    public short? UserSign { get; set; }

    public string? PosCredVal { get; set; }

    public string? IncPrevDoc { get; set; }

    public string? DeclPeriod { get; set; }

    public short? Box1 { get; set; }

    public short? Box2 { get; set; }

    public string? GroupData { get; set; }

    public string? CstRecSt { get; set; }

    public string? TaxCodeExt { get; set; }

    public string? ExportPath { get; set; }

    public int? Llefmabs { get; set; }

    public string? SimpProc { get; set; }

    public string? DspNmass { get; set; }

    public string? ExlDocQt { get; set; }

    public decimal? DocQtLm { get; set; }

    public string? ExlDocAm { get; set; }

    public decimal? DocAmLm { get; set; }

    public short? RunTime { get; set; }

    public string? AddonRun { get; set; }

    public int? BaseDecl { get; set; }

    public string? GroupTrans { get; set; }

    public string? IncGrandDl { get; set; }
}
