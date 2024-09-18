using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TReleve
{
    public int IdReleve { get; set; }

    public string? AdhReleve { get; set; }

    public string? ContratReleve { get; set; }

    public string? PpReleve { get; set; }

    public string? LibelleOpReleve { get; set; }

    public decimal? CreditReleve { get; set; }

    public decimal? DebitReleve { get; set; }

    public decimal? AutreReleve { get; set; }

    public DateTime? DateOpReleve { get; set; }

    public string? EncoursFactureReleve { get; set; }

    public string? DisponibleReleve { get; set; }

    public DateTime? DateReleve { get; set; }
}
