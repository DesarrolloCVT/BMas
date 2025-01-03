using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class Transfer
{
    public int SiteId { get; set; }

    public int TransferId { get; set; }

    public int SiteIdDestiny { get; set; }

    public int IdUsuario { get; set; }

    public DateTime Date { get; set; }

    public int Status { get; set; }

    public int? TransferEntidad { get; set; }

    public int? TransferFolioEntidad { get; set; }

    public string? TransferComentario { get; set; }

    public DateTime? TransferFechaCierre { get; set; }

    public int? FolioSolicitud { get; set; }
}
