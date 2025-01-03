using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwInformeDetencione
{
    public int Of { get; set; }

    public string CategoriaNombre { get; set; } = null!;

    public string MotivoCod { get; set; } = null!;

    public string DetencionMotivo { get; set; } = null!;

    public int? TotalMinutosDetencion { get; set; }

    public string? Comentario { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime? FechConfirma { get; set; }

    public string? UsuarioConfirma { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public short ItmsGrpCod { get; set; }

    public string ItmsGrpNam { get; set; } = null!;

    public short? UNumSala { get; set; }

    public string? ULinea { get; set; }

    public string? UOperador { get; set; }

    public DateTime? DueDate { get; set; }

    public string Linea { get; set; } = null!;

    public TimeOnly HrInicio { get; set; }

    public TimeOnly HrTermino { get; set; }

    public string Tipo { get; set; } = null!;

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public string? Maquina { get; set; }

    public string? Parte { get; set; }

    public string? Componente { get; set; }
}
