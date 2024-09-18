using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TContactFactor
{
    public int IdContact { get; set; }

    public int? RefIndContact { get; set; }

    public string? NomPreContact { get; set; }

    public string? PosContact { get; set; }

    public string? Tel1Contact { get; set; }

    public string? Tel2Contact { get; set; }

    public string? Mail1Contact { get; set; }

    public string? Mail2Contact { get; set; }

    public string? FaxContact { get; set; }

    public bool? ActifContact { get; set; }
}
