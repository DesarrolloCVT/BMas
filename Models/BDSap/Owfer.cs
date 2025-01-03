using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owfer
{
    public int AbsEntry { get; set; }

    public string? MsgId { get; set; }

    public string? MsgDetails { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign { get; set; }

    public int? CreateTime { get; set; }

    public string? MsgTaskId { get; set; }

    public string? MsgErrSrc { get; set; }

    public string? Remark { get; set; }

    public string? MsgType { get; set; }

    public int? MsgInstId { get; set; }

    public int? TemplateId { get; set; }
}
