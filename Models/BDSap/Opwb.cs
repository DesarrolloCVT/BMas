using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opwb
{
    public int AbsEntry { get; set; }

    public string? CardCode { get; set; }

    public string BankCode { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Account { get; set; } = null!;

    public string? Branch { get; set; }

    public string? Street { get; set; }

    public string? Block { get; set; }

    public string? ZipCode { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string? State { get; set; }

    public string? ControlKey { get; set; }

    public string? UsrNumber1 { get; set; }

    public string? UsrNumber2 { get; set; }

    public string? UsrNumber3 { get; set; }

    public string? UsrNumber4 { get; set; }

    public string? Iban { get; set; }

    public int? LogInstanc { get; set; }

    public string? Building { get; set; }

    public string? AliasName { get; set; }

    public string? AcctType { get; set; }

    public int? BankKey { get; set; }

    public string? Bik { get; set; }

    public string? AcctName { get; set; }

    public string? CorresAcct { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public short? Isrtype { get; set; }

    public string? IsrbillerI { get; set; }

    public string? CustIdNum { get; set; }

    public string? AddrType { get; set; }

    public string? StreetNo { get; set; }

    public string? SwiftNum { get; set; }

    public string? AbaroutNum { get; set; }

    public string? MandateId { get; set; }

    public DateTime? SignDate { get; set; }

    public int PwzabsEntr { get; set; }

    public string? BranchChk { get; set; }

    public DateTime? MandatDate { get; set; }

    public string? SeqType { get; set; }

    public string? ActType { get; set; }

    public string? IsPrenot { get; set; }

    public string? EnAccount { get; set; }

    public string? EnIban { get; set; }

    public string? EncryptIv { get; set; }
}
