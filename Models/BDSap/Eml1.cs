using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Eml1
{
    public int AbsEntry { get; set; }

    public int Line { get; set; }

    public int? ObjectId { get; set; }

    public DateTime? DocDate { get; set; }

    public int? DocEntry { get; set; }
}
