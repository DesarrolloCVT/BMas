﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocpr
{
    public int CntctCode { get; set; }

    public string CardCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Position { get; set; }

    public string? Address { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Cellolar { get; set; }

    public string? Fax { get; set; }

    public string? EMailL { get; set; }

    public string? Pager { get; set; }

    public string? Notes1 { get; set; }

    public string? Notes2 { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? Password { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjType { get; set; }

    public string? BirthPlace { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Gender { get; set; }

    public string? Profession { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateTime { get; set; }

    public string? Title { get; set; }

    public string? BirthCity { get; set; }

    public string? Active { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? BirthState { get; set; }

    public string? ResidCity { get; set; }

    public string? ResidCntry { get; set; }

    public string? ResidState { get; set; }

    public string? NfeRcpn { get; set; }

    public string? EmlGrpCode { get; set; }

    public string? BlockComm { get; set; }

    public string? FiscalCode { get; set; }

    public string? CtyPrvsYr { get; set; }

    public string? SttPrvsYr { get; set; }

    public string? CtyCdPrvsY { get; set; }

    public string? CtyCurYr { get; set; }

    public string? SttCurYr { get; set; }

    public string? CtyCdCurYr { get; set; }

    public string? NotResdSch { get; set; }

    public string? CtyFsnCode { get; set; }

    public string? NaturalPer { get; set; }

    public string? Dppstatus { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public string? EncryptIv { get; set; }

    public string? CnnectAddr { get; set; }

    public string? CnAddrType { get; set; }

    public string? Frgncntry { get; set; }
}
