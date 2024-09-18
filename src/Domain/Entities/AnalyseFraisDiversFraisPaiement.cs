using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class AnalyseFraisDiversFraisPaiement
{
    public string TypeFraisDivers { get; set; } = null!;

    public int RefContratFraisDivers { get; set; }

    public decimal? MontantFraisDivers { get; set; }

    public string? LibelléFraisDivers { get; set; }

    public string TypeFraisPaiement { get; set; } = null!;

    public int RefContratFraisPaiement { get; set; }

    public decimal? MontantFraisPaiement { get; set; }

    public string? LibelléFraisPaiement { get; set; }
}
