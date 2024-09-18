using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TRibFactor
{
    public int IdFactor { get; set; }

    public string RibFactor { get; set; } = null!;

    public bool ValidRibFactor { get; set; }
}
