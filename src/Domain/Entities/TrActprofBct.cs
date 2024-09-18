using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TrActprofBct
{
    public string? CodeSection { get; set; }

    public string? Section { get; set; }

    public string? CodeSousSection { get; set; }

    public string? SousSection { get; set; }

    public string? CodeActivité { get; set; }

    public string? CodeClasse { get; set; }

    public string? Classe { get; set; }

    public string? CodeClasse1 { get; set; }

    public string CodeSousClasse { get; set; } = null!;

    public string? SousClasse { get; set; }
}
