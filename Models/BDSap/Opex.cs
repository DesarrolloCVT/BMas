using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opex
{
    public int AbsEntry { get; set; }

    public DateTime? PayRunDate { get; set; }

    public string? VendorNum { get; set; }

    public string? CustNum { get; set; }

    public string? PaymMethod { get; set; }

    public int? PaymDocNum { get; set; }

    public DateTime? FiscalYear { get; set; }

    public string? Country { get; set; }

    public string? CompTaxNum { get; set; }

    public string? PayeeName { get; set; }

    public string? PayeeZip { get; set; }

    public string? PayeeCity { get; set; }

    public string? PayeeStree { get; set; }

    public string? PayCountry { get; set; }

    public string? PayeeState { get; set; }

    public string? PayBnkName { get; set; }

    public string? PayBankZip { get; set; }

    public string? PayBnkCity { get; set; }

    public string? PayBnkStr { get; set; }

    public string? PayBnkCntr { get; set; }

    public string? PayBankAct { get; set; }

    public string? PayBnkCode { get; set; }

    public string? PayBnkCtrl { get; set; }

    public string? PayBnkSwif { get; set; }

    public string? PayBnkIban { get; set; }

    public DateTime? PymPostDat { get; set; }

    public string? PymBnkAcct { get; set; }

    public string? PymBnkCntr { get; set; }

    public string? PymBnkCode { get; set; }

    public string? PymBnkIban { get; set; }

    public string? PymGlacct { get; set; }

    public string? Currency { get; set; }

    public decimal? PymDocAmnt { get; set; }

    public string? PymDocCurr { get; set; }

    public decimal? PymDcAmtFc { get; set; }

    public decimal? PymCshDsct { get; set; }

    public decimal? PyCshDscFc { get; set; }

    public int? PymNumOfPa { get; set; }

    public decimal? PymDocRate { get; set; }

    public string? Status { get; set; }

    public int? PaymWizCod { get; set; }

    public string? InstrucKey { get; set; }

    public string? CllctAutho { get; set; }

    public string? PayBnkPost { get; set; }

    public int? PayBnkChNo { get; set; }

    public string? PayBnkHsBk { get; set; }

    public string? PayBnkBlck { get; set; }

    public string? PayBnkCnty { get; set; }

    public string? PayBnkStat { get; set; }

    public string? PayBnkBisr { get; set; }

    public string? PayBnkUsr1 { get; set; }

    public string? PayBnkUsr2 { get; set; }

    public string? PayBnkUsr3 { get; set; }

    public string? PayBnkUsr4 { get; set; }

    public string? PaymFormat { get; set; }

    public string? CompName { get; set; }

    public string? CompAddres { get; set; }

    public string? CompIsrbil { get; set; }

    public string? VendIsrbil { get; set; }

    public string? AddIdNum { get; set; }

    public string? CompOrgNum { get; set; }

    public string? PayBnkBrnc { get; set; }

    public string? PymBnkBrnc { get; set; }

    public string? UserName { get; set; }

    public string? UserEmail { get; set; }

    public string? UserPortNo { get; set; }

    public string? UserFax { get; set; }

    public short? Department { get; set; }

    public string? DebitMemo { get; set; }

    public string? EuInTrnsfr { get; set; }

    public string? FilePath { get; set; }

    public string? OrderParty { get; set; }

    public string? PymCtrlKey { get; set; }

    public string? PayeeTaxNo { get; set; }

    public string? PymKeyCode { get; set; }

    public string? PayRefDtls { get; set; }

    public string? FormatName { get; set; }

    public string? CheckPmnt { get; set; }

    public string? PymBnkUsr1 { get; set; }

    public string? PymBnkUsr2 { get; set; }

    public string? PymBnkUsr3 { get; set; }

    public string? PymBnkUsr4 { get; set; }

    public string? CompStreet { get; set; }

    public string? CompBlock { get; set; }

    public string? CompCity { get; set; }

    public string? CompZip { get; set; }

    public string? CompCounty { get; set; }

    public string? CompState { get; set; }

    public string? PymBcacode { get; set; }

    public string? PaymDocTyp { get; set; }

    public int? PayOrderNo { get; set; }

    public string? FreeText1 { get; set; }

    public string? FreeText2 { get; set; }

    public string? FreeText3 { get; set; }

    public string? PymBnkSwif { get; set; }

    public string? PayBnkUic { get; set; }

    public string? LineType { get; set; }

    public int? BoeKey { get; set; }

    public string? BoeCurrSta { get; set; }

    public DateTime? BoeDate { get; set; }

    public DateTime? BoeDueDate { get; set; }

    public string? Instruct1 { get; set; }

    public string? Instruct2 { get; set; }

    public string? BoeCancIns { get; set; }

    public string? BoeOccCode { get; set; }

    public string? BoePtfId { get; set; }

    public int? BoeOurNum { get; set; }

    public decimal? BoeIntrAm { get; set; }

    public DateTime? BoeDiscD { get; set; }

    public decimal? BoeDisAmnt { get; set; }

    public DateTime? BoeFineD { get; set; }

    public decimal? BoeFineAmt { get; set; }

    public DateTime? BoeIntrstD { get; set; }

    public decimal? BoeIofamt { get; set; }

    public string? BoeMovCode { get; set; }

    public string? BarcodeRep { get; set; }

    public int? Ponumber { get; set; }

    public int? Poseries { get; set; }

    public string? PaPriority { get; set; }

    public string? PaymType { get; set; }

    public string? RecipStatu { get; set; }

    public string? BudegetId { get; set; }

    public string? Okato { get; set; }

    public string? PymReason { get; set; }

    public string? PostPeriod { get; set; }

    public string? BaseDocTyp { get; set; }

    public DateTime? BaseDocDat { get; set; }

    public string? TaxPymType { get; set; }

    public string? Oktmo { get; set; }

    public string? SeqType { get; set; }

    public DateTime? PymDate { get; set; }

    public string? PymBnkName { get; set; }

    public string? Uipcode { get; set; }

    public short? UserId { get; set; }

    public string? SpltPmtVat { get; set; }

    public string? EnBnkAct { get; set; }

    public string? EnBnkIban { get; set; }

    public string? EncryptIv { get; set; }

    public string? Dppstatus { get; set; }
}
