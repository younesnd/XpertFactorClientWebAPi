using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TGroupe
{
    public int IdGroup { get; set; }

    public int? RefIndGroup { get; set; }

    public string NomGroup { get; set; } = null!;
}
