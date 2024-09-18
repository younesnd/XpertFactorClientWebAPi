using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TrCp
{
    public string Cp { get; set; } = null!;

    public string? Ville { get; set; }

    public string? CodeGouvernorat { get; set; }

    public string? Gouvernorat { get; set; }

    public string? CodeRegion { get; set; }

    public string? Region { get; set; }

    public int IdCp { get; set; }
}
