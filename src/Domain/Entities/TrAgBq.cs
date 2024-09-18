using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TrAgBq
{
    public string CodeBqAg { get; set; } = null!;

    public string? CodeBq { get; set; }

    public string? Banque { get; set; }

    public string? CodeAg { get; set; }

    public string? Agence { get; set; }
}
