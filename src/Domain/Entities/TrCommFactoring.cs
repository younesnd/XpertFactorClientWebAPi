using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TrCommFactoring
{
    public string TypCommFactoring { get; set; } = null!;

    public string? TxCommFactoring { get; set; }

    public decimal? MontMinDocCommFactoring { get; set; }

    public decimal? MontMinCtrCommFactoring { get; set; }

    public int IdCommFact { get; set; }
}
