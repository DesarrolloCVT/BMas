using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlPesoPt
{
    public int IdControlPesoPt { get; set; }

    public DateOnly Fecha { get; set; }

    public int Of { get; set; }

    public int Linea { get; set; }

    public int Sala { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public int PesoPlatillo1 { get; set; }

    public int PesoPlatillo2 { get; set; }

    public int PesoPlatillo3 { get; set; }

    public int PesoPlatillo4 { get; set; }

    public int IdPersonal { get; set; }

    public string? Correccion { get; set; }

    public int? IdEncargadoCalidad { get; set; }

    public string? Idproveedor { get; set; }
}
