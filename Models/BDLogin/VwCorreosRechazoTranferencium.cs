using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwCorreosRechazoTranferencium
{
    public int StaffId { get; set; }

    public int TransferId { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string? MailUsuario { get; set; }
}
