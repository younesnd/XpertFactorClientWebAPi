using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TsParamHab
{
    public int IdPHab { get; set; }

    public string? IdCentreAffPHab { get; set; }

    public string? ChefCentreAffPHab { get; set; }

    public string? ChargeCentreAffPHab { get; set; }

    public string? NomAgPHab { get; set; }

    public string? ChargeClientAgPHab { get; set; }

    public string? ChefAgPHab { get; set; }

    public string? CodeAgPHab { get; set; }

    public bool? ValidePHab { get; set; }
}
