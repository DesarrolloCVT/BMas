using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtGestionExternosBonoJdb
{
    public int Id { get; set; }

    public int? Area { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Trabajador { get; set; }

    public string? MotivoBono { get; set; }

    public TimeOnly? HrsEntrada { get; set; }

    public TimeOnly? HrsSalida { get; set; }

    public string? Usuario { get; set; }

    public int? Valor { get; set; }

    public string? Comentario { get; set; }
}
