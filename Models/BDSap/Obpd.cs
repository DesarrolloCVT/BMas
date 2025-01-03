using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obpd
{
    public int AbsEntry { get; set; }

    public string? DatSubType { get; set; }

    public string? DatSubKey { get; set; }

    public string? DatSubKey2 { get; set; }

    public string? TableName { get; set; }

    public string? KeyValue1 { get; set; }

    public string? KeyValue2 { get; set; }

    public string? KeyValue3 { get; set; }

    public string? KeyValue4 { get; set; }

    public string? KeyValue5 { get; set; }

    public string? FieldName { get; set; }

    public string? EncryptVal { get; set; }

    public string? EncryptIv { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTime { get; set; }
}
